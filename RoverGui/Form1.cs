using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoverGui
{
    public partial class Form1 : Form
    {
        private RoverGuiController _controller;
        private int _mapHeight;
        private int _mapWidth;
        private int _picHeight;
        private int _picWidth;

        public Form1()
        {
            InitializeComponent();
            _controller = new RoverGuiController();
        }

        private void loadFile_button_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt) | *.txt";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string filename = ofd.FileName;
                try
                {
                    _controller.LoadMissionFile(filename);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error loading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }
            SetMapSize();
            execute_button.Invoke(new Action(() => execute_button.Enabled = true));
        }

        private void SetMapSize()
        {
            var mapSize = _controller.GetMapSize();

            // Add rows
            grid_map.RowStyles.Clear();
            grid_map.RowCount = mapSize.Item2 + 1;
            float height = 100f / (float)mapSize.Item2;
            for (int i = 0; i <= mapSize.Item2; i++)
            {
                grid_map.RowStyles.Add(new RowStyle(SizeType.Percent, height));
            }
            
            // Add columns
            grid_map.ColumnCount = mapSize.Item1 + 1;
            grid_map.ColumnStyles.Clear();
            float width = 100f / (float)mapSize.Item1;
            for (int i = 0; i <= mapSize.Item1; i++)
            {
                grid_map.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, width));
            }

            _mapHeight = mapSize.Item2;
            _mapWidth = mapSize.Item1;

            // Get the pic height and width
            _picHeight = grid_map.GetRowHeights()[1];
            _picWidth = grid_map.GetColumnWidths()[1];

            LoadStartPos();
        }

        private void LoadStartPos()
        {
            var startPoses = _controller.GetStartPositions();
            int roversCount = startPoses.Count();
            deployed_label.Invoke(new Action(() => deployed_label.Text = roversCount.ToString()));
            foreach (var startPos in startPoses)
            {
                LoadRoverImage(startPos.XPos, startPos.YPos, startPos.Direction);
            }
        }

        private void LoadRoverImage(int col, int row, RoverMissions.Enums.Orientation direction)
        {
            PictureBox pic = new PictureBox();
            pic.Image = pictureBox1.Image;
            pic.Width = _picWidth;
            pic.Height = _picHeight;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Label direction_label = new Label();
            direction_label.Text = string.Format("({0},{1},{2})", col, row, direction.ToString());
            direction_label.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pic.Controls.Add(direction_label);
            grid_map.Controls.Add(pic, col, (_mapHeight - row));
            pic.Show();
            direction_label.Show();
        }

        void pic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearRovers();
        }

        private void ClearRovers()
        {
            grid_map.Controls.Clear();
            deployed_label.Invoke(new Action(() => deployed_label.Text = "0"));
            execute_button.Invoke(new Action(() => execute_button.Enabled = false));
            success_label.Invoke(new Action(() => success_label.Text = "0"));
            fail_label.Invoke(new Action(() => fail_label.Text = "0"));
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            ExecuteMission();
        }

        private void ExecuteMission()
        {
            var results = _controller.ExecuteMission();
            grid_map.Controls.Clear();
            foreach (var item in results)
            {
                LoadRoverImage(item.Item2.XPos, item.Item2.YPos, item.Item2.Direction);
            }
            int success = results.Count(i => i.Item1 == true);
            int fail = results.Count(i => i.Item1 == false);
            success_label.Invoke(new Action(() => success_label.Text = success.ToString()));
            fail_label.Invoke(new Action(() => fail_label.Text = fail.ToString()));
        }
    }
}

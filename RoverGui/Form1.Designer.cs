namespace RoverGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadFile_button = new System.Windows.Forms.Button();
            this.execute_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fail_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.success_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deployed_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_map = new System.Windows.Forms.TableLayoutPanel();
            this.gridMap = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFile_button
            // 
            this.loadFile_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFile_button.Location = new System.Drawing.Point(6, 19);
            this.loadFile_button.Name = "loadFile_button";
            this.loadFile_button.Size = new System.Drawing.Size(234, 48);
            this.loadFile_button.TabIndex = 1;
            this.loadFile_button.Text = "Load Mission File";
            this.loadFile_button.UseVisualStyleBackColor = true;
            this.loadFile_button.Click += new System.EventHandler(this.loadFile_button_Click);
            // 
            // execute_button
            // 
            this.execute_button.Enabled = false;
            this.execute_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute_button.Location = new System.Drawing.Point(6, 73);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(234, 48);
            this.execute_button.TabIndex = 2;
            this.execute_button.Text = "Execute Mission";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(6, 130);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(234, 48);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Retrieve Rovers";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadFile_button);
            this.groupBox1.Controls.Add(this.clear_button);
            this.groupBox1.Controls.Add(this.execute_button);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(660, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fail_label);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.success_label);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.deployed_label);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(660, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 349);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mission Status";
            // 
            // fail_label
            // 
            this.fail_label.AutoSize = true;
            this.fail_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fail_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fail_label.Location = new System.Drawing.Point(219, 269);
            this.fail_label.Name = "fail_label";
            this.fail_label.Size = new System.Drawing.Size(20, 24);
            this.fail_label.TabIndex = 8;
            this.fail_label.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Failed Missions:";
            // 
            // success_label
            // 
            this.success_label.AutoSize = true;
            this.success_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.success_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success_label.Location = new System.Drawing.Point(219, 155);
            this.success_label.Name = "success_label";
            this.success_label.Size = new System.Drawing.Size(20, 24);
            this.success_label.TabIndex = 6;
            this.success_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Successful Missions:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RoverGui.Properties.Resources.fail;
            this.pictureBox3.Location = new System.Drawing.Point(0, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RoverGui.Properties.Resources.success;
            this.pictureBox2.Location = new System.Drawing.Point(0, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RoverGui.Properties.Resources.rover;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // deployed_label
            // 
            this.deployed_label.AutoSize = true;
            this.deployed_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deployed_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deployed_label.Location = new System.Drawing.Point(220, 57);
            this.deployed_label.Name = "deployed_label";
            this.deployed_label.Size = new System.Drawing.Size(20, 24);
            this.deployed_label.TabIndex = 1;
            this.deployed_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rovers Deployed: ";
            // 
            // grid_map
            // 
            this.grid_map.BackgroundImage = global::RoverGui.Properties.Resources.Mars;
            this.grid_map.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.grid_map.ColumnCount = 1;
            this.grid_map.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid_map.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid_map.Location = new System.Drawing.Point(12, 12);
            this.grid_map.Name = "grid_map";
            this.grid_map.RowCount = 1;
            this.grid_map.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid_map.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid_map.Size = new System.Drawing.Size(642, 544);
            this.grid_map.TabIndex = 0;
            // 
            // gridMap
            // 
            this.gridMap.ColumnCount = 2;
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridMap.Location = new System.Drawing.Point(12, 12);
            this.gridMap.Name = "gridMap";
            this.gridMap.RowCount = 2;
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridMap.Size = new System.Drawing.Size(642, 544);
            this.gridMap.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_map);
            this.Name = "Form1";
            this.Text = "Mission To Mars";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grid_map;
        private System.Windows.Forms.Button loadFile_button;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label deployed_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label success_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label fail_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel gridMap;

    }
}


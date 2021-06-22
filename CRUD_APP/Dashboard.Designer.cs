namespace CRUD_APP
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.DataGridViewGames = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Developers = new System.Windows.Forms.TextBox();
            this.GameTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GUpdate = new System.Windows.Forms.Button();
            this.G_Select_all = new System.Windows.Forms.Button();
            this.G_Reset = new System.Windows.Forms.Button();
            this.G_Print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGames)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewGames
            // 
            this.DataGridViewGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewGames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewGames.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewGames.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewGames.Location = new System.Drawing.Point(12, 247);
            this.DataGridViewGames.Name = "DataGridViewGames";
            this.DataGridViewGames.Size = new System.Drawing.Size(776, 150);
            this.DataGridViewGames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game collector dashboard";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(6, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 37);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Black;
            this.Insert.Location = new System.Drawing.Point(6, 61);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(200, 37);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(6, 105);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(200, 37);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Developers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReleaseDatePicker);
            this.groupBox1.Controls.Add(this.Genre);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Developers);
            this.groupBox1.Controls.Add(this.GameTitle);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 196);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game attributes";
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReleaseDatePicker.Location = new System.Drawing.Point(285, 156);
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(226, 21);
            this.ReleaseDatePicker.TabIndex = 16;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "Sandbox",
            "Real-time strategy (RTS)",
            "Shooter (FPS and TPS)",
            "Multiplayer online battle arena (MOBA)",
            "Role-playing games (RPG)",
            "Simulation and sports",
            "Puzzlers and party games",
            "Action-adventure",
            "Survival and horror",
            "Platformer"});
            this.Genre.Location = new System.Drawing.Point(285, 88);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(226, 22);
            this.Genre.TabIndex = 15;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(285, 121);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(226, 21);
            this.Price.TabIndex = 14;
            // 
            // Developers
            // 
            this.Developers.Location = new System.Drawing.Point(285, 55);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(226, 21);
            this.Developers.TabIndex = 13;
            // 
            // GameTitle
            // 
            this.GameTitle.Location = new System.Drawing.Point(285, 23);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(226, 21);
            this.GameTitle.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GUpdate);
            this.groupBox2.Controls.Add(this.Insert);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(559, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // GUpdate
            // 
            this.GUpdate.BackColor = System.Drawing.Color.Black;
            this.GUpdate.Location = new System.Drawing.Point(6, 148);
            this.GUpdate.Name = "GUpdate";
            this.GUpdate.Size = new System.Drawing.Size(200, 37);
            this.GUpdate.TabIndex = 6;
            this.GUpdate.Text = "Update";
            this.GUpdate.UseVisualStyleBackColor = false;
            this.GUpdate.Click += new System.EventHandler(this.GUpdate_Click);
            // 
            // G_Select_all
            // 
            this.G_Select_all.BackColor = System.Drawing.Color.White;
            this.G_Select_all.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Select_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.G_Select_all.Location = new System.Drawing.Point(5, 404);
            this.G_Select_all.Name = "G_Select_all";
            this.G_Select_all.Size = new System.Drawing.Size(363, 37);
            this.G_Select_all.TabIndex = 13;
            this.G_Select_all.Text = "Display all";
            this.G_Select_all.UseVisualStyleBackColor = false;
            this.G_Select_all.Click += new System.EventHandler(this.G_Select_all_Click);
            // 
            // G_Reset
            // 
            this.G_Reset.BackColor = System.Drawing.Color.White;
            this.G_Reset.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Reset.Location = new System.Drawing.Point(374, 404);
            this.G_Reset.Name = "G_Reset";
            this.G_Reset.Size = new System.Drawing.Size(204, 37);
            this.G_Reset.TabIndex = 14;
            this.G_Reset.Text = "Reset";
            this.G_Reset.UseVisualStyleBackColor = false;
            this.G_Reset.Click += new System.EventHandler(this.G_Reset_Click);
            // 
            // G_Print
            // 
            this.G_Print.BackColor = System.Drawing.Color.White;
            this.G_Print.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Print.Location = new System.Drawing.Point(584, 404);
            this.G_Print.Name = "G_Print";
            this.G_Print.Size = new System.Drawing.Size(204, 37);
            this.G_Print.TabIndex = 15;
            this.G_Print.Text = "Print";
            this.G_Print.UseVisualStyleBackColor = false;
            this.G_Print.Click += new System.EventHandler(this.G_Print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(802, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G_Print);
            this.Controls.Add(this.G_Reset);
            this.Controls.Add(this.G_Select_all);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewGames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker ReleaseDatePicker;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Developers;
        private System.Windows.Forms.TextBox GameTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GUpdate;
        private System.Windows.Forms.Button G_Select_all;
        private System.Windows.Forms.Button G_Reset;
        private System.Windows.Forms.Button G_Print;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
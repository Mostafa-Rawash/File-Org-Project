
namespace project_file_org
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.FilenametextBox = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.searching = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.player_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Positon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.player_nationality = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.Label();
            this.richbox = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilenametextBox
            // 
            this.FilenametextBox.BackColor = System.Drawing.Color.White;
            this.FilenametextBox.Location = new System.Drawing.Point(84, 32);
            this.FilenametextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilenametextBox.Name = "FilenametextBox";
            this.FilenametextBox.Size = new System.Drawing.Size(195, 22);
            this.FilenametextBox.TabIndex = 1;
            this.FilenametextBox.TextChanged += new System.EventHandler(this.FilenametextBox_TextChanged);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.create.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Location = new System.Drawing.Point(287, 33);
            this.create.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 24);
            this.create.TabIndex = 2;
            this.create.Text = "Create ";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // searching
            // 
            this.searching.AutoSize = true;
            this.searching.BackColor = System.Drawing.Color.Transparent;
            this.searching.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searching.ForeColor = System.Drawing.Color.White;
            this.searching.Location = new System.Drawing.Point(465, 37);
            this.searching.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(131, 17);
            this.searching.TabIndex = 3;
            this.searching.Text = "Search using name";
            this.searching.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(604, 37);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(165, 22);
            this.searchInput.TabIndex = 4;
            this.searchInput.TextChanged += new System.EventHandler(this.PositionnametextBox_TextChanged);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Transparent;
            this.Remove.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(383, 33);
            this.Remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(74, 24);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(167, 305);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 31);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Transparent;
            this.Display.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(293, 305);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(127, 31);
            this.Display.TabIndex = 7;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.Transparent;
            this.warning.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Aqua;
            this.warning.Location = new System.Drawing.Point(24, 65);
            this.warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(59, 17);
            this.warning.TabIndex = 9;
            this.warning.Text = "warning";
            this.warning.Visible = false;
            this.warning.Click += new System.EventHandler(this.warning_Click);
            // 
            // player_name
            // 
            this.player_name.Location = new System.Drawing.Point(167, 167);
            this.player_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(253, 22);
            this.player_name.TabIndex = 11;
            this.player_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Player name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Positon
            // 
            this.Positon.Location = new System.Drawing.Point(167, 201);
            this.Positon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Positon.Name = "Positon";
            this.Positon.Size = new System.Drawing.Size(253, 22);
            this.Positon.TabIndex = 14;
            this.Positon.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Positon";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Team
            // 
            this.Team.Location = new System.Drawing.Point(167, 233);
            this.Team.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(253, 22);
            this.Team.TabIndex = 16;
            this.Team.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Team";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // player_nationality
            // 
            this.player_nationality.Location = new System.Drawing.Point(167, 267);
            this.player_nationality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_nationality.Name = "player_nationality";
            this.player_nationality.Size = new System.Drawing.Size(253, 22);
            this.player_nationality.TabIndex = 19;
            this.player_nationality.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Nationality
            // 
            this.Nationality.AutoSize = true;
            this.Nationality.BackColor = System.Drawing.Color.Transparent;
            this.Nationality.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nationality.Location = new System.Drawing.Point(64, 274);
            this.Nationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(77, 17);
            this.Nationality.TabIndex = 18;
            this.Nationality.Text = "Nationality";
            this.Nationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nationality.Click += new System.EventHandler(this.label8_Click);
            // 
            // richbox
            // 
            this.richbox.BackColor = System.Drawing.Color.White;
            this.richbox.Location = new System.Drawing.Point(523, 107);
            this.richbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richbox.Name = "richbox";
            this.richbox.Size = new System.Drawing.Size(314, 271);
            this.richbox.TabIndex = 20;
            this.richbox.Text = "";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Transparent;
            this.Search.Location = new System.Drawing.Point(781, 36);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(82, 26);
            this.Search.TabIndex = 21;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 513);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.richbox);
            this.Controls.Add(this.player_nationality);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Positon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.create);
            this.Controls.Add(this.FilenametextBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilenametextBox;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label searching;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.TextBox player_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Positon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Team;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox player_nationality;
        private System.Windows.Forms.Label Nationality;
        private System.Windows.Forms.RichTextBox richbox;
        private System.Windows.Forms.Button Search;
    }
}


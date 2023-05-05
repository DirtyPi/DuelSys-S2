namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStartTournament = new System.Windows.Forms.Button();
            this.lbTournamentList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndTour = new System.Windows.Forms.DateTimePicker();
            this.btnAddTournament = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescriptionT = new System.Windows.Forms.TextBox();
            this.nudMaxPlayersT = new System.Windows.Forms.NumericUpDown();
            this.tbLocationT = new System.Windows.Forms.TextBox();
            this.dtpStartT = new System.Windows.Forms.DateTimePicker();
            this.nudMinPlayersT = new System.Windows.Forms.NumericUpDown();
            this.cbTypeOfSportT = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btLogOff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayersT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayersT)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 460);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStartTournament);
            this.tabPage1.Controls.Add(this.lbTournamentList);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tournament List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStartTournament
            // 
            this.btnStartTournament.Location = new System.Drawing.Point(8, 251);
            this.btnStartTournament.Name = "btnStartTournament";
            this.btnStartTournament.Size = new System.Drawing.Size(246, 89);
            this.btnStartTournament.TabIndex = 1;
            this.btnStartTournament.Text = "Start Tournament";
            this.btnStartTournament.UseVisualStyleBackColor = true;
            this.btnStartTournament.Click += new System.EventHandler(this.btnStartTournament_Click);
            // 
            // lbTournamentList
            // 
            this.lbTournamentList.FormattingEnabled = true;
            this.lbTournamentList.ItemHeight = 20;
            this.lbTournamentList.Location = new System.Drawing.Point(8, 27);
            this.lbTournamentList.Name = "lbTournamentList";
            this.lbTournamentList.Size = new System.Drawing.Size(1009, 204);
            this.lbTournamentList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtpEndTour);
            this.tabPage2.Controls.Add(this.btnAddTournament);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbDescriptionT);
            this.tabPage2.Controls.Add(this.nudMaxPlayersT);
            this.tabPage2.Controls.Add(this.tbLocationT);
            this.tabPage2.Controls.Add(this.dtpStartT);
            this.tabPage2.Controls.Add(this.nudMinPlayersT);
            this.tabPage2.Controls.Add(this.cbTypeOfSportT);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tournament Managment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tournament end:";
            // 
            // dtpEndTour
            // 
            this.dtpEndTour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndTour.Location = new System.Drawing.Point(169, 236);
            this.dtpEndTour.Name = "dtpEndTour";
            this.dtpEndTour.Size = new System.Drawing.Size(250, 27);
            this.dtpEndTour.TabIndex = 14;
            // 
            // btnAddTournament
            // 
            this.btnAddTournament.Location = new System.Drawing.Point(606, 156);
            this.btnAddTournament.Name = "btnAddTournament";
            this.btnAddTournament.Size = new System.Drawing.Size(167, 107);
            this.btnAddTournament.TabIndex = 13;
            this.btnAddTournament.Text = "Publish";
            this.btnAddTournament.UseVisualStyleBackColor = true;
            this.btnAddTournament.Click += new System.EventHandler(this.btnAddTournament_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tournament start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimum players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of sport:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(431, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create a tournament";
            // 
            // tbDescriptionT
            // 
            this.tbDescriptionT.Location = new System.Drawing.Point(169, 336);
            this.tbDescriptionT.Multiline = true;
            this.tbDescriptionT.Name = "tbDescriptionT";
            this.tbDescriptionT.Size = new System.Drawing.Size(368, 72);
            this.tbDescriptionT.TabIndex = 5;
            // 
            // nudMaxPlayersT
            // 
            this.nudMaxPlayersT.Location = new System.Drawing.Point(170, 157);
            this.nudMaxPlayersT.Name = "nudMaxPlayersT";
            this.nudMaxPlayersT.Size = new System.Drawing.Size(250, 27);
            this.nudMaxPlayersT.TabIndex = 4;
            // 
            // tbLocationT
            // 
            this.tbLocationT.Location = new System.Drawing.Point(169, 288);
            this.tbLocationT.Name = "tbLocationT";
            this.tbLocationT.Size = new System.Drawing.Size(251, 27);
            this.tbLocationT.TabIndex = 3;
            // 
            // dtpStartT
            // 
            this.dtpStartT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartT.Location = new System.Drawing.Point(170, 199);
            this.dtpStartT.Name = "dtpStartT";
            this.dtpStartT.Size = new System.Drawing.Size(250, 27);
            this.dtpStartT.TabIndex = 2;
            // 
            // nudMinPlayersT
            // 
            this.nudMinPlayersT.Location = new System.Drawing.Point(172, 113);
            this.nudMinPlayersT.Name = "nudMinPlayersT";
            this.nudMinPlayersT.Size = new System.Drawing.Size(250, 27);
            this.nudMinPlayersT.TabIndex = 1;
            // 
            // cbTypeOfSportT
            // 
            this.cbTypeOfSportT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfSportT.Location = new System.Drawing.Point(171, 70);
            this.cbTypeOfSportT.Name = "cbTypeOfSportT";
            this.cbTypeOfSportT.Size = new System.Drawing.Size(251, 28);
            this.cbTypeOfSportT.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cbRole);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.tbFullName);
            this.tabPage3.Controls.Add(this.tbPassword);
            this.tabPage3.Controls.Add(this.tbEmail);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1030, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee Managment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(395, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 28);
            this.label14.TabIndex = 9;
            this.label14.Text = "Register user to system";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Role:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Full name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email:";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(165, 241);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(288, 28);
            this.cbRole.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register to system";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(165, 182);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(288, 27);
            this.tbFullName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(165, 131);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(288, 27);
            this.tbPassword.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(165, 86);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(288, 27);
            this.tbEmail.TabIndex = 0;
            // 
            // btLogOff
            // 
            this.btLogOff.Location = new System.Drawing.Point(952, 484);
            this.btLogOff.Name = "btLogOff";
            this.btLogOff.Size = new System.Drawing.Size(94, 29);
            this.btLogOff.TabIndex = 3;
            this.btLogOff.Text = "Log out";
            this.btLogOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 525);
            this.Controls.Add(this.btLogOff);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayersT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayersT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStartTournament;
        private System.Windows.Forms.ListBox lbTournamentList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddTournament;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescriptionT;
        private System.Windows.Forms.NumericUpDown nudMaxPlayersT;
        private System.Windows.Forms.TextBox tbLocationT;
        private System.Windows.Forms.DateTimePicker dtpStartT;
        private System.Windows.Forms.NumericUpDown nudMinPlayersT;
        private System.Windows.Forms.ComboBox cbTypeOfSportT;
        private System.Windows.Forms.Button btLogOff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndTour;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
    }
}

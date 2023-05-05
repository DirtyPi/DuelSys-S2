namespace DuelSysForms
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnSortByPlayers = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.btnStartTournament = new System.Windows.Forms.Button();
            this.lbTournamentList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.btLogOff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayersT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayersT)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnSortByPlayers);
            this.tabPage1.Controls.Add(this.btnSortByDate);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(808, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sort by:";
            // 
            // btnSortByPlayers
            // 
            this.btnSortByPlayers.Location = new System.Drawing.Point(808, 56);
            this.btnSortByPlayers.Name = "btnSortByPlayers";
            this.btnSortByPlayers.Size = new System.Drawing.Size(195, 29);
            this.btnSortByPlayers.TabIndex = 5;
            this.btnSortByPlayers.Text = "Players";
            this.btnSortByPlayers.UseVisualStyleBackColor = true;
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(808, 102);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(195, 29);
            this.btnSortByDate.TabIndex = 4;
            this.btnSortByDate.Text = "Date";
            this.btnSortByDate.UseVisualStyleBackColor = true;
            // 
            // btnStartTournament
            // 
            this.btnStartTournament.Location = new System.Drawing.Point(8, 251);
            this.btnStartTournament.Name = "btnStartTournament";
            this.btnStartTournament.Size = new System.Drawing.Size(246, 89);
            this.btnStartTournament.TabIndex = 1;
            this.btnStartTournament.Text = "btnStartTour";
            this.btnStartTournament.UseVisualStyleBackColor = true;
            this.btnStartTournament.Click += new System.EventHandler(this.btnStartTournament_Click);
            // 
            // lbTournamentList
            // 
            this.lbTournamentList.FormattingEnabled = true;
            this.lbTournamentList.ItemHeight = 20;
            this.lbTournamentList.Location = new System.Drawing.Point(6, 26);
            this.lbTournamentList.Name = "lbTournamentList";
            this.lbTournamentList.Size = new System.Drawing.Size(785, 204);
            this.lbTournamentList.TabIndex = 0;
            // 
            // tabPage2
            // 
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
            this.label7.Location = new System.Drawing.Point(75, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tournament start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimum players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of sport:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(428, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create a tournament";
            // 
            // tbDescriptionT
            // 
            this.tbDescriptionT.Location = new System.Drawing.Point(169, 292);
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
            this.tbLocationT.Location = new System.Drawing.Point(169, 244);
            this.tbLocationT.Name = "tbLocationT";
            this.tbLocationT.Size = new System.Drawing.Size(251, 27);
            this.tbLocationT.TabIndex = 3;
            // 
            // dtpStartT
            // 
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
            // btLogOff
            // 
            this.btLogOff.Location = new System.Drawing.Point(944, 470);
            this.btLogOff.Name = "btLogOff";
            this.btLogOff.Size = new System.Drawing.Size(94, 29);
            this.btLogOff.TabIndex = 2;
            this.btLogOff.Text = "Log out";
            this.btLogOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 511);
            this.Controls.Add(this.btLogOff);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayersT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayersT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnStartTournament;
        private ListBox lbTournamentList;
        private TabPage tabPage2;
        private Button btLogOff;
        private Button btnAddTournament;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbDescriptionT;
        private NumericUpDown nudMaxPlayersT;
        private TextBox tbLocationT;
        private DateTimePicker dtpStartT;
        private NumericUpDown nudMinPlayersT;
        private ComboBox cbTypeOfSportT;
        private Label label8;
        private Button btnSortByPlayers;
        private Button btnSortByDate;
    }
}
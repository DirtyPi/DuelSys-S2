namespace DuelSys
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbTournaments = new System.Windows.Forms.ListBox();
            this.btnOpenTournament = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartOfTourn = new System.Windows.Forms.DateTimePicker();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.nUDMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.nUDMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.cbTypeOfSport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddTournament = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMaxPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnOpenTournament);
            this.tabPage1.Controls.Add(this.lbTournaments);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tournament Manger";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddTournament);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbTypeOfSport);
            this.tabPage2.Controls.Add(this.nUDMaxPlayers);
            this.tabPage2.Controls.Add(this.nUDMinPlayers);
            this.tabPage2.Controls.Add(this.tbDescription);
            this.tabPage2.Controls.Add(this.tbLocation);
            this.tabPage2.Controls.Add(this.dtpStartOfTourn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Tournament";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(931, 444);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 31);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lbTournaments
            // 
            this.lbTournaments.FormattingEnabled = true;
            this.lbTournaments.ItemHeight = 16;
            this.lbTournaments.Location = new System.Drawing.Point(8, 8);
            this.lbTournaments.Name = "lbTournaments";
            this.lbTournaments.Size = new System.Drawing.Size(863, 180);
            this.lbTournaments.TabIndex = 0;
            // 
            // btnOpenTournament
            // 
            this.btnOpenTournament.Location = new System.Drawing.Point(8, 214);
            this.btnOpenTournament.Name = "btnOpenTournament";
            this.btnOpenTournament.Size = new System.Drawing.Size(265, 64);
            this.btnOpenTournament.TabIndex = 1;
            this.btnOpenTournament.Text = "Open Tournament";
            this.btnOpenTournament.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Date ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(877, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Player Count";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by:";
            // 
            // dtpStartOfTourn
            // 
            this.dtpStartOfTourn.Location = new System.Drawing.Point(200, 164);
            this.dtpStartOfTourn.Name = "dtpStartOfTourn";
            this.dtpStartOfTourn.Size = new System.Drawing.Size(250, 22);
            this.dtpStartOfTourn.TabIndex = 0;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(200, 204);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(250, 22);
            this.tbLocation.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(201, 253);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(250, 107);
            this.tbDescription.TabIndex = 4;
            // 
            // nUDMinPlayers
            // 
            this.nUDMinPlayers.Location = new System.Drawing.Point(201, 81);
            this.nUDMinPlayers.Name = "nUDMinPlayers";
            this.nUDMinPlayers.Size = new System.Drawing.Size(250, 22);
            this.nUDMinPlayers.TabIndex = 5;
            // 
            // nUDMaxPlayers
            // 
            this.nUDMaxPlayers.Location = new System.Drawing.Point(201, 118);
            this.nUDMaxPlayers.Name = "nUDMaxPlayers";
            this.nUDMaxPlayers.Size = new System.Drawing.Size(250, 22);
            this.nUDMaxPlayers.TabIndex = 6;
            // 
            // cbTypeOfSport
            // 
            this.cbTypeOfSport.FormattingEnabled = true;
            this.cbTypeOfSport.Location = new System.Drawing.Point(200, 51);
            this.cbTypeOfSport.Name = "cbTypeOfSport";
            this.cbTypeOfSport.Size = new System.Drawing.Size(251, 24);
            this.cbTypeOfSport.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sport Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minimum players:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tournaments strats:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Create a tournament";
            // 
            // btnAddTournament
            // 
            this.btnAddTournament.Location = new System.Drawing.Point(519, 253);
            this.btnAddTournament.Name = "btnAddTournament";
            this.btnAddTournament.Size = new System.Drawing.Size(128, 80);
            this.btnAddTournament.TabIndex = 15;
            this.btnAddTournament.Text = "Publish";
            this.btnAddTournament.UseVisualStyleBackColor = true;
            this.btnAddTournament.Click += new System.EventHandler(this.btnAddTournament_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 487);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMaxPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenTournament;
        private System.Windows.Forms.ListBox lbTournaments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddTournament;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypeOfSport;
        private System.Windows.Forms.NumericUpDown nUDMaxPlayers;
        private System.Windows.Forms.NumericUpDown nUDMinPlayers;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.DateTimePicker dtpStartOfTourn;
        private System.Windows.Forms.Button btnLogOut;
    }
}
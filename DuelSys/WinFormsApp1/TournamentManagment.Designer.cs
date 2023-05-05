namespace WinFormsApp1
{
    partial class TournamentManagment
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
            this.lbMatches = new System.Windows.Forms.ListBox();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.btnOpenGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRanking = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMatches
            // 
            this.lbMatches.FormattingEnabled = true;
            this.lbMatches.ItemHeight = 20;
            this.lbMatches.Location = new System.Drawing.Point(12, 51);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(698, 124);
            this.lbMatches.TabIndex = 0;
            this.lbMatches.SelectedIndexChanged += new System.EventHandler(this.lbMatches_SelectedIndexChanged);
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.ItemHeight = 20;
            this.lbGames.Location = new System.Drawing.Point(12, 201);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(698, 124);
            this.lbGames.TabIndex = 1;
            // 
            // btnOpenGame
            // 
            this.btnOpenGame.Location = new System.Drawing.Point(742, 201);
            this.btnOpenGame.Name = "btnOpenGame";
            this.btnOpenGame.Size = new System.Drawing.Size(113, 124);
            this.btnOpenGame.TabIndex = 2;
            this.btnOpenGame.Text = "Open Round";
            this.btnOpenGame.UseVisualStyleBackColor = true;
            this.btnOpenGame.Click += new System.EventHandler(this.btnOpenGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matches:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Games:";
            // 
            // lbRanking
            // 
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.ItemHeight = 20;
            this.lbRanking.Location = new System.Drawing.Point(12, 361);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(698, 204);
            this.lbRanking.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ranking:";
            // 
            // TournamentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 597);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRanking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenGame);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.lbMatches);
            this.Name = "TournamentManagment";
            this.Text = "TournamentManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMatches;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Button btnOpenGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRanking;
        private System.Windows.Forms.Label label4;
    }
}
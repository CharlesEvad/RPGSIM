namespace RPGSIM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblCharacter1 = new System.Windows.Forms.Label();
            this.cbCharacter1 = new System.Windows.Forms.ComboBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblCharacter2 = new System.Windows.Forms.Label();
            this.cbCharacter2 = new System.Windows.Forms.ComboBox();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.lstBattleLog = new System.Windows.Forms.ListBox();
            this.lblHealth1 = new System.Windows.Forms.Label();
            this.lblHealth2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPlayer1.Location = new System.Drawing.Point(40, 35);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(142, 24);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1 Name:";

            this.txtPlayer1.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPlayer1.Location = new System.Drawing.Point(190, 32);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(200, 29);
            this.txtPlayer1.TabIndex = 1;

            this.lblCharacter1.AutoSize = true;
            this.lblCharacter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCharacter1.Location = new System.Drawing.Point(40, 80);
            this.lblCharacter1.Name = "lblCharacter1";
            this.lblCharacter1.Size = new System.Drawing.Size(108, 24);
            this.lblCharacter1.TabIndex = 2;
            this.lblCharacter1.Text = "Character 1:";

            this.cbCharacter1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCharacter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbCharacter1.FormattingEnabled = true;
            this.cbCharacter1.Location = new System.Drawing.Point(190, 76);
            this.cbCharacter1.Name = "cbCharacter1";
            this.cbCharacter1.Size = new System.Drawing.Size(200, 28);
            this.cbCharacter1.TabIndex = 3;
            this.cbCharacter1.SelectedIndexChanged += new System.EventHandler(this.cbCharacter1_SelectedIndexChanged);

            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPlayer2.Location = new System.Drawing.Point(450, 35);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(142, 24);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Player 2 Name:";

            this.txtPlayer2.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPlayer2.Location = new System.Drawing.Point(600, 32);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(200, 29);
            this.txtPlayer2.TabIndex = 5;

            this.lblCharacter2.AutoSize = true;
            this.lblCharacter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCharacter2.Location = new System.Drawing.Point(450, 80);
            this.lblCharacter2.Name = "lblCharacter2";
            this.lblCharacter2.Size = new System.Drawing.Size(108, 24);
            this.lblCharacter2.TabIndex = 6;
            this.lblCharacter2.Text = "Character 2:";

            this.cbCharacter2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCharacter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbCharacter2.FormattingEnabled = true;
            this.cbCharacter2.Location = new System.Drawing.Point(600, 76);
            this.cbCharacter2.Name = "cbCharacter2";
            this.cbCharacter2.Size = new System.Drawing.Size(200, 28);
            this.cbCharacter2.TabIndex = 7;
            this.cbCharacter2.SelectedIndexChanged += new System.EventHandler(this.cbCharacter2_SelectedIndexChanged);

            this.btnStartBattle.BackColor = System.Drawing.Color.Red;
            this.btnStartBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnStartBattle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartBattle.Location = new System.Drawing.Point(350, 130);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(200, 45);
            this.btnStartBattle.TabIndex = 8;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = false;

            this.lstBattleLog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstBattleLog.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstBattleLog.FormattingEnabled = true;
            this.lstBattleLog.ItemHeight = 21;
            this.lstBattleLog.Location = new System.Drawing.Point(40, 200);
            this.lstBattleLog.Name = "lstBattleLog";
            this.lstBattleLog.Size = new System.Drawing.Size(760, 151);
            this.lstBattleLog.TabIndex = 9;

            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.lblHealth1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblHealth2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblWinner);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(830, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 430);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIMULATOR";

            this.lblHealth1.AutoSize = true;
            this.lblHealth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHealth1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHealth1.Location = new System.Drawing.Point(35, 40);
            this.lblHealth1.Name = "lblHealth1";
            this.lblHealth1.Size = new System.Drawing.Size(90, 20);
            this.lblHealth1.TabIndex = 11;
            this.lblHealth1.Text = "Health 1: ";

            this.pictureBox1.Location = new System.Drawing.Point(30, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;

            this.lblHealth2.AutoSize = true;
            this.lblHealth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHealth2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHealth2.Location = new System.Drawing.Point(230, 40);
            this.lblHealth2.Name = "lblHealth2";
            this.lblHealth2.Size = new System.Drawing.Size(90, 20);
            this.lblHealth2.TabIndex = 12;
            this.lblHealth2.Text = "Health 2: ";

            this.pictureBox2.Location = new System.Drawing.Point(225, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;

            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblWinner.Location = new System.Drawing.Point(130, 270);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(101, 26);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "Winner:";

            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1300, 500);
            this.Controls.Add(this.lstBattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.cbCharacter2);
            this.Controls.Add(this.lblCharacter2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.cbCharacter1);
            this.Controls.Add(this.lblCharacter1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Form1";
            this.Text = "RPGSIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblCharacter1;
        private System.Windows.Forms.ComboBox cbCharacter1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblCharacter2;
        private System.Windows.Forms.ComboBox cbCharacter2;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.ListBox lstBattleLog;
        private System.Windows.Forms.Label lblHealth1;
        private System.Windows.Forms.Label lblHealth2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
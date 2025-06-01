namespace EliteClass
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
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.BattleLog = new System.Windows.Forms.ListBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.panelPlayer1Body = new System.Windows.Forms.Panel();
            this.panelPlayer2Body = new System.Windows.Forms.Panel();
            this.panelPlayer1Health = new System.Windows.Forms.Panel();
            this.panelPlayer2Health = new System.Windows.Forms.Panel();
            this.lblPlayer1HP = new System.Windows.Forms.Label();
            this.lblPlayer2HP = new System.Windows.Forms.Label();
            this.lblPlayer2Health = new System.Windows.Forms.Label();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.panelPlayer2Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Orange;
            this.Player2.ForeColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(21, 12);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(100, 22);
            this.Player2.TabIndex = 0;
            this.Player2.Text = "Player2";
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Orange;
            this.Player1.ForeColor = System.Drawing.Color.White;
            this.Player1.Location = new System.Drawing.Point(235, 115);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(100, 22);
            this.Player1.TabIndex = 1;
            this.Player1.Text = "Player1";
            this.Player1.TextChanged += new System.EventHandler(this.Player1_TextChanged);
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.BackColor = System.Drawing.Color.Orange;
            this.cmbPlayer1.ForeColor = System.Drawing.Color.Black;
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Location = new System.Drawing.Point(212, 173);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(121, 24);
            this.cmbPlayer1.TabIndex = 2;
            this.cmbPlayer1.Text = "cmbPlayer1";
            this.cmbPlayer1.SelectedIndexChanged += new System.EventHandler(this.cbm_SelectedIndexChanged);
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.BackColor = System.Drawing.Color.Orange;
            this.cmbPlayer2.ForeColor = System.Drawing.Color.Black;
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Location = new System.Drawing.Point(496, 173);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(121, 24);
            this.cmbPlayer2.TabIndex = 3;
            this.cmbPlayer2.Text = "cmbPlayer2";
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.BackColor = System.Drawing.Color.Orange;
            this.btnStartBattle.ForeColor = System.Drawing.Color.White;
            this.btnStartBattle.Location = new System.Drawing.Point(393, 245);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(100, 42);
            this.btnStartBattle.TabIndex = 4;
            this.btnStartBattle.Text = "StartBattle";
            this.btnStartBattle.UseVisualStyleBackColor = false;
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);
            // 
            // BattleLog
            // 
            this.BattleLog.BackColor = System.Drawing.Color.Orange;
            this.BattleLog.ForeColor = System.Drawing.Color.White;
            this.BattleLog.FormattingEnabled = true;
            this.BattleLog.ItemHeight = 16;
            this.BattleLog.Location = new System.Drawing.Point(258, 354);
            this.BattleLog.Name = "BattleLog";
            this.BattleLog.Size = new System.Drawing.Size(371, 84);
            this.BattleLog.TabIndex = 5;
            this.BattleLog.SelectedIndexChanged += new System.EventHandler(this.BattleLog_SelectedIndexChanged);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Orange;
            this.lblWinner.Location = new System.Drawing.Point(399, 370);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(63, 16);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "lblWinner";
            // 
            // panelPlayer1Body
            // 
            this.panelPlayer1Body.BackColor = System.Drawing.Color.Orange;
            this.panelPlayer1Body.Location = new System.Drawing.Point(212, 103);
            this.panelPlayer1Body.Name = "panelPlayer1Body";
            this.panelPlayer1Body.Size = new System.Drawing.Size(157, 51);
            this.panelPlayer1Body.TabIndex = 9;
            // 
            // panelPlayer2Body
            // 
            this.panelPlayer2Body.BackColor = System.Drawing.Color.Orange;
            this.panelPlayer2Body.Controls.Add(this.Player2);
            this.panelPlayer2Body.Location = new System.Drawing.Point(496, 103);
            this.panelPlayer2Body.Name = "panelPlayer2Body";
            this.panelPlayer2Body.Size = new System.Drawing.Size(157, 51);
            this.panelPlayer2Body.TabIndex = 10;
            // 
            // panelPlayer1Health
            // 
            this.panelPlayer1Health.BackColor = System.Drawing.Color.Lime;
            this.panelPlayer1Health.Location = new System.Drawing.Point(212, 53);
            this.panelPlayer1Health.Name = "panelPlayer1Health";
            this.panelPlayer1Health.Size = new System.Drawing.Size(184, 44);
            this.panelPlayer1Health.TabIndex = 11;
            // 
            // panelPlayer2Health
            // 
            this.panelPlayer2Health.BackColor = System.Drawing.Color.Lime;
            this.panelPlayer2Health.Location = new System.Drawing.Point(496, 53);
            this.panelPlayer2Health.Name = "panelPlayer2Health";
            this.panelPlayer2Health.Size = new System.Drawing.Size(184, 44);
            this.panelPlayer2Health.TabIndex = 12;
            this.panelPlayer2Health.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer2Health_Paint);
            // 
            // lblPlayer1HP
            // 
            this.lblPlayer1HP.AutoSize = true;
            this.lblPlayer1HP.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1HP.Location = new System.Drawing.Point(212, 31);
            this.lblPlayer1HP.Name = "lblPlayer1HP";
            this.lblPlayer1HP.Size = new System.Drawing.Size(26, 16);
            this.lblPlayer1HP.TabIndex = 13;
            this.lblPlayer1HP.Text = "HP";
            // 
            // lblPlayer2HP
            // 
            this.lblPlayer2HP.AutoSize = true;
            this.lblPlayer2HP.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2HP.Location = new System.Drawing.Point(496, 31);
            this.lblPlayer2HP.Name = "lblPlayer2HP";
            this.lblPlayer2HP.Size = new System.Drawing.Size(26, 16);
            this.lblPlayer2HP.TabIndex = 14;
            this.lblPlayer2HP.Text = "HP";
            // 
            // lblPlayer2Health
            // 
            this.lblPlayer2Health.AutoSize = true;
            this.lblPlayer2Health.BackColor = System.Drawing.Color.Lime;
            this.lblPlayer2Health.Location = new System.Drawing.Point(525, 31);
            this.lblPlayer2Health.Name = "lblPlayer2Health";
            this.lblPlayer2Health.Size = new System.Drawing.Size(92, 16);
            this.lblPlayer2Health.TabIndex = 7;
            this.lblPlayer2Health.Text = "Player2Health";
            this.lblPlayer2Health.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayer1Health
            // 
            this.lblPlayer1Health.AutoSize = true;
            this.lblPlayer1Health.BackColor = System.Drawing.Color.Lime;
            this.lblPlayer1Health.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1Health.Location = new System.Drawing.Point(241, 31);
            this.lblPlayer1Health.Name = "lblPlayer1Health";
            this.lblPlayer1Health.Size = new System.Drawing.Size(92, 16);
            this.lblPlayer1Health.TabIndex = 6;
            this.lblPlayer1Health.Text = "Player1Health";
            this.lblPlayer1Health.Click += new System.EventHandler(this.lblPlayer1Health_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayer2Health);
            this.Controls.Add(this.lblPlayer1Health);
            this.Controls.Add(this.lblPlayer2HP);
            this.Controls.Add(this.lblPlayer1HP);
            this.Controls.Add(this.BattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.cmbPlayer2);
            this.Controls.Add(this.cmbPlayer1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.panelPlayer2Body);
            this.Controls.Add(this.panelPlayer1Body);
            this.Controls.Add(this.panelPlayer1Health);
            this.Controls.Add(this.panelPlayer2Health);
            this.Controls.Add(this.lblWinner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPlayer2Body.ResumeLayout(false);
            this.panelPlayer2Body.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.ListBox BattleLog;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Panel panelPlayer1Body;
        private System.Windows.Forms.Panel panelPlayer2Body;
        private System.Windows.Forms.Panel panelPlayer1Health;
        private System.Windows.Forms.Panel panelPlayer2Health;
        private System.Windows.Forms.Label lblPlayer1HP;
        private System.Windows.Forms.Label lblPlayer2HP;
        private System.Windows.Forms.Label lblPlayer1Health;
        private System.Windows.Forms.Label lblPlayer2Health;
    }
}


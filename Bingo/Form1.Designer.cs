namespace Bingo
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtRNG = new System.Windows.Forms.TextBox();
            this.btnNoHave = new System.Windows.Forms.Button();
            this.lblBingoCardTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(355, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(162, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Weclome to the Game of BINGO";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(339, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name at the right";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(482, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(214, 80);
            this.lblReady.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(112, 13);
            this.lblReady.TabIndex = 3;
            this.lblReady.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(372, 70);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 33);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes! Let\'s GO!";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(500, 70);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(97, 33);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No! Exit!";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblRules
            // 
            this.lblRules.Location = new System.Drawing.Point(150, 134);
            this.lblRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(447, 50);
            this.lblRules.TabIndex = 6;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // txtRNG
            // 
            this.txtRNG.Location = new System.Drawing.Point(613, 93);
            this.txtRNG.Margin = new System.Windows.Forms.Padding(2);
            this.txtRNG.Multiline = true;
            this.txtRNG.Name = "txtRNG";
            this.txtRNG.ReadOnly = true;
            this.txtRNG.Size = new System.Drawing.Size(76, 59);
            this.txtRNG.TabIndex = 7;
            // 
            // btnNoHave
            // 
            this.btnNoHave.Location = new System.Drawing.Point(613, 156);
            this.btnNoHave.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoHave.Name = "btnNoHave";
            this.btnNoHave.Size = new System.Drawing.Size(76, 28);
            this.btnNoHave.TabIndex = 8;
            this.btnNoHave.Text = "Don\'t Have";
            this.btnNoHave.UseVisualStyleBackColor = true;
            // 
            // lblBingoCardTitle
            // 
            this.lblBingoCardTitle.Location = new System.Drawing.Point(372, 184);
            this.lblBingoCardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBingoCardTitle.Name = "lblBingoCardTitle";
            this.lblBingoCardTitle.Size = new System.Drawing.Size(106, 32);
            this.lblBingoCardTitle.TabIndex = 9;
            this.lblBingoCardTitle.Text = "Your Bingo Card";
            this.lblBingoCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBingoCardTitle.Visible = false;
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(153, 229);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(536, 578);
            this.pnlCard.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 818);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblBingoCardTitle);
            this.Controls.Add(this.btnNoHave);
            this.Controls.Add(this.txtRNG);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TextBox txtRNG;
        private System.Windows.Forms.Button btnNoHave;
        private System.Windows.Forms.Label lblBingoCardTitle;
        private System.Windows.Forms.Panel pnlCard;
    }
}


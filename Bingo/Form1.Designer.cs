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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(473, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(212, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Weclome to the Game of BINGO";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(452, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name at the right";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(643, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(285, 98);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(151, 17);
            this.lblReady.TabIndex = 3;
            this.lblReady.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(496, 86);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(141, 41);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes! Let\'s GO!";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(667, 86);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(129, 41);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No! Exit!";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblRules
            // 
            this.lblRules.Location = new System.Drawing.Point(200, 165);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(596, 62);
            this.lblRules.TabIndex = 6;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // txtRNG
            // 
            this.txtRNG.Location = new System.Drawing.Point(817, 114);
            this.txtRNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRNG.Multiline = true;
            this.txtRNG.Name = "txtRNG";
            this.txtRNG.ReadOnly = true;
            this.txtRNG.Size = new System.Drawing.Size(100, 72);
            this.txtRNG.TabIndex = 7;
            // 
            // btnNoHave
            // 
            this.btnNoHave.Location = new System.Drawing.Point(817, 192);
            this.btnNoHave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoHave.Name = "btnNoHave";
            this.btnNoHave.Size = new System.Drawing.Size(101, 34);
            this.btnNoHave.TabIndex = 8;
            this.btnNoHave.Text = "Don\'t Have";
            this.btnNoHave.UseVisualStyleBackColor = true;
            this.btnNoHave.Click += new System.EventHandler(this.btnNoHave_Click);
            // 
            // lblBingoCardTitle
            // 
            this.lblBingoCardTitle.Location = new System.Drawing.Point(496, 226);
            this.lblBingoCardTitle.Name = "lblBingoCardTitle";
            this.lblBingoCardTitle.Size = new System.Drawing.Size(141, 39);
            this.lblBingoCardTitle.TabIndex = 9;
            this.lblBingoCardTitle.Text = "Your Bingo Card";
            this.lblBingoCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBingoCardTitle.Visible = false;
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(204, 282);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(715, 711);
            this.pnlCard.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "blah";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 1007);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
    }
}


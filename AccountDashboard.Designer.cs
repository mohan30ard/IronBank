namespace phase_1
{
    partial class AccountDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountSummary = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnFundTransfer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccountStatements = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAccountStatements);
            this.panel1.Controls.Add(this.btnFundTransfer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnAccounts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAccountSummary);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 521);
            this.panel1.TabIndex = 0;
            // 
            // btnAccountSummary
            // 
            this.btnAccountSummary.FlatAppearance.BorderSize = 0;
            this.btnAccountSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSummary.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnAccountSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountSummary.Location = new System.Drawing.Point(12, 171);
            this.btnAccountSummary.Name = "btnAccountSummary";
            this.btnAccountSummary.Size = new System.Drawing.Size(174, 36);
            this.btnAccountSummary.TabIndex = 8;
            this.btnAccountSummary.Text = "Account Summary";
            this.btnAccountSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSummary.UseVisualStyleBackColor = true;
            this.btnAccountSummary.Click += new System.EventHandler(this.btnAccountSummary_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(21, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Accounts";
            // 
            // btnAccounts
            // 
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnAccounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccounts.Location = new System.Drawing.Point(12, 213);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(174, 36);
            this.btnAccounts.TabIndex = 10;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(21, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Transactions";
            // 
            // btnTransactions
            // 
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransactions.Location = new System.Drawing.Point(12, 287);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(174, 36);
            this.btnTransactions.TabIndex = 10;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // btnFundTransfer
            // 
            this.btnFundTransfer.FlatAppearance.BorderSize = 0;
            this.btnFundTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFundTransfer.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnFundTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFundTransfer.Location = new System.Drawing.Point(12, 329);
            this.btnFundTransfer.Name = "btnFundTransfer";
            this.btnFundTransfer.Size = new System.Drawing.Size(174, 36);
            this.btnFundTransfer.TabIndex = 13;
            this.btnFundTransfer.Text = "Fund Transfer";
            this.btnFundTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundTransfer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::phase_1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(63, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(21, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Servuces";
            // 
            // btnAccountStatements
            // 
            this.btnAccountStatements.FlatAppearance.BorderSize = 0;
            this.btnAccountStatements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountStatements.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnAccountStatements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountStatements.Location = new System.Drawing.Point(12, 396);
            this.btnAccountStatements.Name = "btnAccountStatements";
            this.btnAccountStatements.Size = new System.Drawing.Size(174, 36);
            this.btnAccountStatements.TabIndex = 14;
            this.btnAccountStatements.Text = "Account Statements";
            this.btnAccountStatements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountStatements.UseVisualStyleBackColor = true;
            // 
            // AccountDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(929, 521);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccountSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnFundTransfer;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccountStatements;
    }
}
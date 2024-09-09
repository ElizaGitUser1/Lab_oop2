namespace Bank_Account1
{
    partial class Bank_Acc
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
            this.lbsum = new System.Windows.Forms.Label();
            this.tbDepositAmount = new System.Windows.Forms.TextBox();
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lbmin = new System.Windows.Forms.Label();
            this.lbAccNum = new System.Windows.Forms.Label();
            this.tbWithdrawAmount = new System.Windows.Forms.TextBox();
            this.tbAccNum = new System.Windows.Forms.TextBox();
            this.btCreateAcc = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsum
            // 
            this.lbsum.AutoSize = true;
            this.lbsum.Location = new System.Drawing.Point(12, 26);
            this.lbsum.Name = "lbsum";
            this.lbsum.Size = new System.Drawing.Size(200, 16);
            this.lbsum.TabIndex = 0;
            this.lbsum.Text = "Введіть суму для поповнення";
            // 
            // tbDepositAmount
            // 
            this.tbDepositAmount.Location = new System.Drawing.Point(15, 59);
            this.tbDepositAmount.Name = "tbDepositAmount";
            this.tbDepositAmount.Size = new System.Drawing.Size(197, 22);
            this.tbDepositAmount.TabIndex = 1;
            // 
            // btDeposit
            // 
            this.btDeposit.BackColor = System.Drawing.Color.DarkOrange;
            this.btDeposit.Location = new System.Drawing.Point(15, 107);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(100, 35);
            this.btDeposit.TabIndex = 2;
            this.btDeposit.Text = "Поповнити";
            this.btDeposit.UseVisualStyleBackColor = false;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // btWithdraw
            // 
            this.btWithdraw.BackColor = System.Drawing.Color.Peru;
            this.btWithdraw.Location = new System.Drawing.Point(15, 273);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(106, 35);
            this.btWithdraw.TabIndex = 3;
            this.btWithdraw.Text = "Зняти кошти";
            this.btWithdraw.UseVisualStyleBackColor = false;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.Color.Gold;
            this.btnShowInfo.Location = new System.Drawing.Point(543, 107);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(164, 47);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "Показати інформацію";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lbmin
            // 
            this.lbmin.AutoSize = true;
            this.lbmin.Location = new System.Drawing.Point(12, 193);
            this.lbmin.Name = "lbmin";
            this.lbmin.Size = new System.Drawing.Size(210, 16);
            this.lbmin.TabIndex = 5;
            this.lbmin.Text = "Введіть суму для зняття коштів";
            // 
            // lbAccNum
            // 
            this.lbAccNum.AutoSize = true;
            this.lbAccNum.Location = new System.Drawing.Point(425, 26);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(157, 16);
            this.lbAccNum.TabIndex = 6;
            this.lbAccNum.Text = "Введіть номер рахунку";
            // 
            // tbWithdrawAmount
            // 
            this.tbWithdrawAmount.Location = new System.Drawing.Point(15, 228);
            this.tbWithdrawAmount.Name = "tbWithdrawAmount";
            this.tbWithdrawAmount.Size = new System.Drawing.Size(197, 22);
            this.tbWithdrawAmount.TabIndex = 7;
            // 
            // tbAccNum
            // 
            this.tbAccNum.Location = new System.Drawing.Point(428, 59);
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.Size = new System.Drawing.Size(197, 22);
            this.tbAccNum.TabIndex = 8;
            // 
            // btCreateAcc
            // 
            this.btCreateAcc.BackColor = System.Drawing.Color.Yellow;
            this.btCreateAcc.Location = new System.Drawing.Point(346, 107);
            this.btCreateAcc.Name = "btCreateAcc";
            this.btCreateAcc.Size = new System.Drawing.Size(164, 47);
            this.btCreateAcc.TabIndex = 9;
            this.btCreateAcc.Text = "Створити рахунок";
            this.btCreateAcc.UseVisualStyleBackColor = false;
            this.btCreateAcc.Click += new System.EventHandler(this.btCreateAcc_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(425, 184);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(58, 16);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Баланс:";
            // 
            // Bank_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btCreateAcc);
            this.Controls.Add(this.tbAccNum);
            this.Controls.Add(this.tbWithdrawAmount);
            this.Controls.Add(this.lbAccNum);
            this.Controls.Add(this.lbmin);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.btDeposit);
            this.Controls.Add(this.tbDepositAmount);
            this.Controls.Add(this.lbsum);
            this.Name = "Bank_Acc";
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbsum;
        private System.Windows.Forms.TextBox tbDepositAmount;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lbmin;
        private System.Windows.Forms.Label lbAccNum;
        private System.Windows.Forms.TextBox tbWithdrawAmount;
        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.Button btCreateAcc;
        private System.Windows.Forms.Label lblBalance;
    }
}


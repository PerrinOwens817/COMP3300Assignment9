namespace COMP3300Assignment9PerrinOwens
{
    partial class MainForm
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
            btnSelectFile = new Button();
            lblFileName = new Label();
            lstAccounts = new ListBox();
            btnShowSavings = new Button();
            btnShowChecking = new Button();
            bnShowMoneyMarket = new Button();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(416, 304);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(185, 29);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select JSON File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(320, 9);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(50, 20);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "label1";
            // 
            // lstAccounts
            // 
            lstAccounts.FormattingEnabled = true;
            lstAccounts.Location = new Point(12, 34);
            lstAccounts.Name = "lstAccounts";
            lstAccounts.Size = new Size(974, 264);
            lstAccounts.TabIndex = 2;
            // 
            // btnShowSavings
            // 
            btnShowSavings.Location = new Point(416, 339);
            btnShowSavings.Name = "btnShowSavings";
            btnShowSavings.Size = new Size(185, 29);
            btnShowSavings.TabIndex = 3;
            btnShowSavings.Text = "Show Savings";
            btnShowSavings.UseVisualStyleBackColor = true;
            btnShowSavings.Click += btnShowSavings_Click;
            // 
            // btnShowChecking
            // 
            btnShowChecking.Location = new Point(416, 374);
            btnShowChecking.Name = "btnShowChecking";
            btnShowChecking.Size = new Size(185, 29);
            btnShowChecking.TabIndex = 4;
            btnShowChecking.Text = "Show Checking";
            btnShowChecking.UseVisualStyleBackColor = true;
            btnShowChecking.Click += btnShowChecking_Click_1;
            // 
            // bnShowMoneyMarket
            // 
            bnShowMoneyMarket.Location = new Point(416, 409);
            bnShowMoneyMarket.Name = "bnShowMoneyMarket";
            bnShowMoneyMarket.Size = new Size(185, 29);
            bnShowMoneyMarket.TabIndex = 5;
            bnShowMoneyMarket.Text = "Show Money Market";
            bnShowMoneyMarket.UseVisualStyleBackColor = true;
            bnShowMoneyMarket.Click += bnShowMoneyMarket_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 450);
            Controls.Add(bnShowMoneyMarket);
            Controls.Add(btnShowChecking);
            Controls.Add(btnShowSavings);
            Controls.Add(lstAccounts);
            Controls.Add(lblFileName);
            Controls.Add(btnSelectFile);
            Name = "MainForm";
            Text = "Assignment 9 by Owens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label lblFileName;
        private ListBox lstAccounts;
        private Button btnShowSavings;
        private Button btnShowChecking;
        private Button bnShowMoneyMarket;
    }
}

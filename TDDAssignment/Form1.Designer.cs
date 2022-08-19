namespace TDDAssignment
{
    partial class Account
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
            this.rateBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.principalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(12, 156);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(210, 26);
            this.rateBox.TabIndex = 0;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(12, 238);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(210, 26);
            this.timeBox.TabIndex = 1;
            // 
            // principalBox
            // 
            this.principalBox.Location = new System.Drawing.Point(12, 84);
            this.principalBox.Name = "principalBox";
            this.principalBox.Size = new System.Drawing.Size(210, 26);
            this.principalBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Time (Months)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(100, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(615, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fools Paradise Bank";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(450, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(395, 311);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(224, 26);
            this.amountBox.TabIndex = 8;
            this.amountBox.TextChanged += new System.EventHandler(this.amountBox_TextChanged);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(275, 317);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(104, 20);
            this.amount.TabIndex = 9;
            this.amount.Text = "Amount Rate";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.principalBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.rateBox);
            this.Name = "Account";
            this.Text = "Welcome to Fools Paradise Bank";
            this.Load += new System.EventHandler(this.Savings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox principalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label amount;
    }
}


namespace CandyMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbCandy = new System.Windows.Forms.RadioButton();
            this.rbChips = new System.Windows.Forms.RadioButton();
            this.rbGum = new System.Windows.Forms.RadioButton();
            this.rbCookies = new System.Windows.Forms.RadioButton();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SHELLY\'S CANDY SHOP";
            // 
            // rbCandy
            // 
            this.rbCandy.AutoSize = true;
            this.rbCandy.Location = new System.Drawing.Point(142, 83);
            this.rbCandy.Name = "rbCandy";
            this.rbCandy.Size = new System.Drawing.Size(55, 17);
            this.rbCandy.TabIndex = 1;
            this.rbCandy.TabStop = true;
            this.rbCandy.Text = "Candy";
            this.rbCandy.UseVisualStyleBackColor = true;
            // 
            // rbChips
            // 
            this.rbChips.AutoSize = true;
            this.rbChips.Location = new System.Drawing.Point(142, 106);
            this.rbChips.Name = "rbChips";
            this.rbChips.Size = new System.Drawing.Size(51, 17);
            this.rbChips.TabIndex = 2;
            this.rbChips.TabStop = true;
            this.rbChips.Text = "Chips";
            this.rbChips.UseVisualStyleBackColor = true;
            // 
            // rbGum
            // 
            this.rbGum.AutoSize = true;
            this.rbGum.Location = new System.Drawing.Point(142, 129);
            this.rbGum.Name = "rbGum";
            this.rbGum.Size = new System.Drawing.Size(47, 17);
            this.rbGum.TabIndex = 3;
            this.rbGum.TabStop = true;
            this.rbGum.Text = "Gum";
            this.rbGum.UseVisualStyleBackColor = true;
            // 
            // rbCookies
            // 
            this.rbCookies.AutoSize = true;
            this.rbCookies.Location = new System.Drawing.Point(142, 152);
            this.rbCookies.Name = "rbCookies";
            this.rbCookies.Size = new System.Drawing.Size(63, 17);
            this.rbCookies.TabIndex = 4;
            this.rbCookies.TabStop = true;
            this.rbCookies.Text = "Cookies";
            this.rbCookies.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(142, 203);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 304);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.rbCookies);
            this.Controls.Add(this.rbGum);
            this.Controls.Add(this.rbChips);
            this.Controls.Add(this.rbCandy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Candy Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCandy;
        private System.Windows.Forms.RadioButton rbChips;
        private System.Windows.Forms.RadioButton rbGum;
        private System.Windows.Forms.RadioButton rbCookies;
        private System.Windows.Forms.Button btnPurchase;
    }
}


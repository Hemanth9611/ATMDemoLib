namespace ATMService
{
    partial class WithDrawFormUI
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
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnWithDrawAmount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWithDraw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CardNumber";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(343, 109);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(145, 20);
            this.txtCardNumber.TabIndex = 1;
            // 
            // btnWithDrawAmount
            // 
            this.btnWithDrawAmount.Location = new System.Drawing.Point(343, 255);
            this.btnWithDrawAmount.Name = "btnWithDrawAmount";
            this.btnWithDrawAmount.Size = new System.Drawing.Size(75, 23);
            this.btnWithDrawAmount.TabIndex = 2;
            this.btnWithDrawAmount.Text = "WithDraw";
            this.btnWithDrawAmount.UseVisualStyleBackColor = true;
            this.btnWithDrawAmount.Click += new System.EventHandler(this.btnWithDrawAmount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // txtWithDraw
            // 
            this.txtWithDraw.Location = new System.Drawing.Point(343, 166);
            this.txtWithDraw.Name = "txtWithDraw";
            this.txtWithDraw.Size = new System.Drawing.Size(145, 20);
            this.txtWithDraw.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Withdraw section";
            // 
            // WithDrawFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWithDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWithDrawAmount);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label1);
            this.Name = "WithDrawFormUI";
            this.Text = "WithDrawFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnWithDrawAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWithDraw;
        private System.Windows.Forms.Label label3;
    }
}
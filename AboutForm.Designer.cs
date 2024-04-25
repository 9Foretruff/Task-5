namespace WindowsFormsApp4
{
    partial class AboutForm
    {
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClose;

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(60, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = " Призвіще:Рокітько\n Ім'я: Максим\n Група:ІПЗ-21\n Варіант:5";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(120, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInfo);
            this.Name = "AboutForm";
            this.Text = "Про програму";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
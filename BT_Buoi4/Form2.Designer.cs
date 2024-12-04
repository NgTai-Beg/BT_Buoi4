namespace BT_Buoi4
{
    partial class Form2
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.boxLuong = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxMSSV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(520, 321);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Bo Qua";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(234, 321);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 14;
            this.btnYes.Text = "Dong Y";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click_1);
            // 
            // boxLuong
            // 
            this.boxLuong.Location = new System.Drawing.Point(364, 209);
            this.boxLuong.Name = "boxLuong";
            this.boxLuong.Size = new System.Drawing.Size(231, 20);
            this.boxLuong.TabIndex = 13;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(364, 148);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(231, 20);
            this.boxName.TabIndex = 12;
            // 
            // boxMSSV
            // 
            this.boxMSSV.Location = new System.Drawing.Point(364, 107);
            this.boxMSSV.Name = "boxMSSV";
            this.boxMSSV.Size = new System.Drawing.Size(231, 20);
            this.boxMSSV.TabIndex = 11;
            // 
            // txtLuong
            // 
            this.txtLuong.AutoSize = true;
            this.txtLuong.Location = new System.Drawing.Point(205, 209);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(73, 13);
            this.txtLuong.TabIndex = 10;
            this.txtLuong.Text = "Luong co ban";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(205, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 13);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Ten nhan vien";
            // 
            // txtMSSV
            // 
            this.txtMSSV.AutoSize = true;
            this.txtMSSV.Location = new System.Drawing.Point(205, 107);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(38, 13);
            this.txtMSSV.TabIndex = 8;
            this.txtMSSV.Text = "MSNV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.boxLuong);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.boxMSSV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox boxLuong;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxMSSV;
        private System.Windows.Forms.Label txtLuong;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtMSSV;
    }
}
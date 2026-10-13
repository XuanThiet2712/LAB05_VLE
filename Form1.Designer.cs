namespace Lab05_VLE
{
    partial class frmNhapLieu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số cột";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số dòng";
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(283, 25);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(95, 77);
            this.btnKhoiTao.TabIndex = 2;
            this.btnKhoiTao.Text = "Khởi tạo form";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // txtSoDong
            // 
            this.txtSoDong.Location = new System.Drawing.Point(123, 25);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(100, 22);
            this.txtSoDong.TabIndex = 3;
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(112, 79);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(100, 22);
            this.txtSoCot.TabIndex = 4;
            // 
            // frmNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 178);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapLieu";
            this.Text = "frmNhapLieu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox txtSoCot;
    }
}


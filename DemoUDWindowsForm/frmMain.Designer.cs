namespace DemoUDWindowsForm
{
    partial class frmMain
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
            this.btnDauCong = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnDauTru = new System.Windows.Forms.Button();
            this.btnDauNhan = new System.Windows.Forms.Button();
            this.btnDauChia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUONG TRINH MAY TINH";
            // 
            // btnDauCong
            // 
            this.btnDauCong.Location = new System.Drawing.Point(254, 228);
            this.btnDauCong.Name = "btnDauCong";
            this.btnDauCong.Size = new System.Drawing.Size(88, 59);
            this.btnDauCong.TabIndex = 1;
            this.btnDauCong.Text = "+";
            this.btnDauCong.UseVisualStyleBackColor = true;
            this.btnDauCong.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(269, 119);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(331, 26);
            this.txtSoA.TabIndex = 2;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(269, 151);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(331, 26);
            this.txtSoB.TabIndex = 3;
            // 
            // btnDauTru
            // 
            this.btnDauTru.Location = new System.Drawing.Point(348, 228);
            this.btnDauTru.Name = "btnDauTru";
            this.btnDauTru.Size = new System.Drawing.Size(81, 59);
            this.btnDauTru.TabIndex = 1;
            this.btnDauTru.Text = "-";
            this.btnDauTru.UseVisualStyleBackColor = true;
            this.btnDauTru.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnDauNhan
            // 
            this.btnDauNhan.Location = new System.Drawing.Point(435, 228);
            this.btnDauNhan.Name = "btnDauNhan";
            this.btnDauNhan.Size = new System.Drawing.Size(82, 59);
            this.btnDauNhan.TabIndex = 1;
            this.btnDauNhan.Text = "*";
            this.btnDauNhan.UseVisualStyleBackColor = true;
            this.btnDauNhan.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnDauChia
            // 
            this.btnDauChia.Location = new System.Drawing.Point(523, 228);
            this.btnDauChia.Name = "btnDauChia";
            this.btnDauChia.Size = new System.Drawing.Size(77, 59);
            this.btnDauChia.TabIndex = 1;
            this.btnDauChia.Text = "/";
            this.btnDauChia.UseVisualStyleBackColor = true;
            this.btnDauChia.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "So A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "So B";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(269, 183);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(331, 26);
            this.txtKetQua.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ket Qua";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.btnDauChia);
            this.Controls.Add(this.btnDauNhan);
            this.Controls.Add(this.btnDauTru);
            this.Controls.Add(this.btnDauCong);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDauCong;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnDauTru;
        private System.Windows.Forms.Button btnDauNhan;
        private System.Windows.Forms.Button btnDauChia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
    }
}


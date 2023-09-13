
namespace _2180607804_ngothainguyen_Lab02_03
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblmananh = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(204, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 253);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblmananh
            // 
            this.lblmananh.AutoSize = true;
            this.lblmananh.Location = new System.Drawing.Point(355, 26);
            this.lblmananh.Name = "lblmananh";
            this.lblmananh.Size = new System.Drawing.Size(50, 13);
            this.lblmananh.TabIndex = 1;
            this.lblmananh.Text = "Màn Ảnh";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(204, 335);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Location = new System.Drawing.Point(330, 335);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 23);
            this.btnHuybo.TabIndex = 2;
            this.btnHuybo.Text = "Huỷ Bỏ";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(474, 335);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetthuc.TabIndex = 3;
            this.btnKetthuc.Text = "Kết Thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Location = new System.Drawing.Point(249, 309);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(62, 13);
            this.lblThanhtien.TabIndex = 4;
            this.lblThanhtien.Text = "Thành Tiền";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(317, 306);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(266, 20);
            this.txtThanhtien.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.lblThanhtien);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblmananh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblmananh;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.TextBox txtThanhtien;
    }
}


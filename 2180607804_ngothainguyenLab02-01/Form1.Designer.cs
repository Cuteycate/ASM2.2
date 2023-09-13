namespace _2180607804_ngothainguyenLab02_01
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
            this.btnMul = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(387, 166);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(43, 41);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(329, 166);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(43, 41);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(445, 166);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(43, 41);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.button4_Click);
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(195, 106);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(50, 13);
            this.Number1.TabIndex = 6;
            this.Number1.Text = "Number1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(195, 143);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(53, 13);
            this.lblNumber2.TabIndex = 7;
            this.lblNumber2.Text = "Number 2";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(268, 103);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(220, 20);
            this.txtNumber1.TabIndex = 8;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(268, 140);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(220, 20);
            this.txtNumber2.TabIndex = 9;
            // 
            // lblNumber3
            // 
            this.lblNumber3.AutoSize = true;
            this.lblNumber3.Location = new System.Drawing.Point(195, 236);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(53, 13);
            this.lblNumber3.TabIndex = 10;
            this.lblNumber3.Text = "Number 3";
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(268, 233);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(220, 20);
            this.txtNumber3.TabIndex = 11;
            this.txtNumber3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.TextBox txtNumber3;
    }
}


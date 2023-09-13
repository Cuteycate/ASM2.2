using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180607804_ngothainguyen_Lab02_03
{
    public partial class Form1 : Form
    {
        int thanhtien = 0;
        List<Button> DanhSachChon = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddButtons()
        {
            for(int i=1;i<21;i++)
            {
                Button btn = new Button();
                btn.Size = new Size(60, 50);
                btn.Text = i.ToString();
                btn.Click += btnChooseASeat;
                btn.BackColor = Color.White;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddButtons();
        }
        private void btnChooseASeat(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                DanhSachChon.Add(btn);
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                DanhSachChon.Remove(btn);
            }
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghe Da Duoc Ban !!!!!");

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach(Button b in DanhSachChon)
            {
                int a = int.Parse(b.Text);
                if(a<=5 && b.BackColor == Color.Blue)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 30000;
                }
                if (a >5 && a<=10 && b.BackColor == Color.Blue)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 40000;
                }
                if (a > 10 && a<=15 && b.BackColor == Color.Blue)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 50000;
                }
                if (a >15 && a<=20 && b.BackColor == Color.Blue)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 80000;
                }
                txtThanhtien.Text = thanhtien.ToString();
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach(Button b in DanhSachChon)
            {
                b.BackColor = Color.White;
            }
            txtThanhtien.Text = "0";
            thanhtien = 0;
            DanhSachChon = new List<Button>();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

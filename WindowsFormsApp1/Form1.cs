using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> listint = new List<int>();
        public Form1()
        {
            InitializeComponent();
            for(int i=0;i<20;i++)
            {
                listint.Add(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = new Random().Next(0, listint.Count);
            textBox1.Text = listint[i].ToString();
            listint.RemoveAt(i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5ad.Text = textBox1.Text;
            label6soyad.Text = textBox2.Text;
            label7dogum_yeri.Text = textBox3.Text;
            label8alan.Text = textBox4.Text;
        }
    }
}

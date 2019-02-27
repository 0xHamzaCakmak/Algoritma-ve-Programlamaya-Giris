using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_ekim_ders_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sdsd_Click(object sender, EventArgs e)
        {
            textBox1.Text = "hello görsel";
        }

        private void yaz_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button salih = new Button();
            salih.Text = "dinamik salih";
            salih.Location = new Point(25, 30);
            salih.Size = new Size(150, 50);
            this.Controls.Add(salih);

        }
    }
}

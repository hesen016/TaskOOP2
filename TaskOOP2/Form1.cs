using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insan ins = new Insan();
            ins.Name = textBox1.Text;
            ins.Surname = textBox2.Text;
            ins.Birth_year =Convert.ToInt32(textBox3.Text);

            label4.Text =ins.Name;
            label5.Text = ins.Surname;
            label6.Text = ins.Birth_year.ToString();

            int yash = ins.GetAge(ins.Birth_year);
            label7.Text = yash.ToString();
        }
    }
}

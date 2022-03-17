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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car tt = new Toyota();

            tt.Start();
            tt.Stop();

            TestCar(tt);

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Car aa = new Audi();
            aa.Start();
            aa.Stop();
            TestCar(aa);


           
        }
        public void TestCar(Car data)
        {
            MessageBox.Show("Car Testing");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal at = new Horse();

            at.GetVoice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal it = new Dog();

            it.GetVoice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Iarifmetik arifmetik = new Operations();
            int eded=arifmetik.Topla(10, 2);

            MessageBox.Show(eded.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Imentiqi mentiqi = new Operations();

            bool netice=mentiqi.cutdurmu(40);
            MessageBox.Show(netice.ToString());

        }
    }
}

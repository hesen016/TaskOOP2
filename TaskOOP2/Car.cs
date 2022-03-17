using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    public  class Car
    {
       public string marka;
       public string model;
       public int speed;


        public virtual void Start()
        {
            System.Windows.Forms.MessageBox.Show("Car Starting");

        }

        public virtual void Stop()
        {
            System.Windows.Forms.MessageBox.Show("Car stoping");
        }
    }
}

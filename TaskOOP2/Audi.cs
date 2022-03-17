using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    public  class Audi:Car
    {
        public string aPackage;

        public override void Start()
        {
            System.Windows.Forms.MessageBox.Show("Audi Starting");
        }

        public override void Stop()
        {
            System.Windows.Forms.MessageBox.Show("Audi Stopping");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    public class Toyota:Car
    {
        public string tPackage;

        public override void Start()
        {
            System.Windows.Forms.MessageBox.Show("Toyota Starting");
        }

        public override void Stop()
        {
            System.Windows.Forms.MessageBox.Show("Toyota Stopping");
        }
    }
}

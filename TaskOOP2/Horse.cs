using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    internal class Horse : Animal
    {
        public override void GetVoice()
        {
            System.Windows.Forms.MessageBox.Show("at sesi");
        }
    }
}

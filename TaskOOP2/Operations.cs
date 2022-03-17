using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    internal class Operations : Iarifmetik, Imentiqi
    {
        public bool cutdurmu(int eded)
        {
            bool netice = false;

            if (eded%2==0)
            {
                netice = true;
            }
            return netice;
        }

        public int Topla(int a, int b)
        {
            int netice = a + b;
            return netice;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Second:First
    {
        private bool P;
    
        public Second(bool P, double cabel_type, double count_g, double diametr): base(cabel_type, count_g, diametr)
        {
            this.P = P;

        }
        public double Qp()
        {
            double result = 0;
            if (P)
                result = 2 * base.Q();
            else result = 0.7 * base.Q();
            return result;
        }
    }
}

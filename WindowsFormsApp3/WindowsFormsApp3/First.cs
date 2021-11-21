using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class First
    {
        private double cabel_type;
        private double count_g;
        private double diametr;
        public First(double cabel_type, double count_g, double diametr)
        {
            this.cabel_type = cabel_type;
            this.count_g = count_g;
            this.diametr = diametr;
        }
        public virtual double Q()
        {
            return diametr / count_g;
        }
            
    }
}

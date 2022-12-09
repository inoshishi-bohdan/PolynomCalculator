using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    public abstract class Function 
    {
        public Function()
        {

        }
        public abstract double Calc(double x);
        public abstract Function Derivative();
        public abstract override string ToString();
    }
}

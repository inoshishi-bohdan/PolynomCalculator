using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    public class Arguments : Function
    {
        public override double Calc(double x)
        {
            return x;
        }
        public override string ToString()
        {
            return "x";
        }
        public override Function Derivative()
        {
            return new Constant(1);
        }
    }
}

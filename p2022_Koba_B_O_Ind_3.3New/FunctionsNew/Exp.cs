using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    public class Exp : Unary
    {
        public Exp(Function arguments) : base(arguments)
        {
            function = Math.Exp;
        }
        public override double Calc(double x)
        {
            return function(arguments.Calc(x));
        }
        public override Function Derivative()
        {
            return new Multiply(arguments, new Exp(new Subtract(arguments, new Constant(1))));
        }
    }
}

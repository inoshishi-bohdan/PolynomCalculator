using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    public class Cos : Unary
    {
        public Cos(Function arguments) : base(arguments)
        {
            function = Math.Cos;
        }
        public override Function Derivative()
        {
            return new Multiply(new Constant(-1), new Multiply(new Sin(arguments), arguments.Derivative()));
        }
    }
}

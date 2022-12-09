using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;


namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    internal class Tan : Unary
    {
        public Tan(Function arguments) : base(arguments)
        {
            function = Math.Tan;
        }
        public override Function Derivative()
        {
            return new Multiply(new Divide(new Constant(1), new Multiply(new Cos(arguments), new Cos(arguments))) , arguments.Derivative());
        }
    }
}

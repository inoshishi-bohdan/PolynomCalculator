using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    internal class Sin : Unary
    {
        public Sin(Function arguments) : base(arguments)
        {
            function = Math.Sin;
        }
        public override Function Derivative()
        {
            return new Multiply(new Cos(arguments), arguments.Derivative());
        }
    }
}

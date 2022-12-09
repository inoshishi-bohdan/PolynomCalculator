using p2022_Koba_B_O_Ind_3._3.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3New.FunctionsNew
{
    public class Ln : Unary
    {
        public Ln(Function arguments) : base(arguments)
        {
            function = Math.Log;
        }
        public override Function Derivative()
        {
            return new Multiply(new Divide(new Constant(1), arguments), arguments.Derivative());
        }
    }
}

using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    internal class CTan : Unary
    {
        public CTan(Function arguments) : base(arguments)
        {
            function = Ctan;
        }
        public override Function Derivative()
        {
            return new Multiply(new Divide(new Constant(-1), new Multiply(new Sin(arguments), new Sin(arguments))), arguments.Derivative());
        }
        private double Ctan(double radians)
        {
            return 1 / Math.Tan(radians);
        }
    }
}

using p2022_Koba_B_O_Ind_3._3.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3New.FunctionsNew
{
    public class Subtract : Binary
    {
        public Subtract(Function left, Function right) : base(left, right)
        {
            operation = "-";
            func = (x, y) => x - y;
        }
        public override Function Derivative()
        {
            return new Subtract(Left.Derivative(), Right.Derivative());
        }
    }
}

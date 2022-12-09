using p2022_Koba_B_O_Ind_3._3.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3New.FunctionsNew
{
    public class Divide : Binary
    {
        public Divide(Function left, Function right) : base(left, right)
        {
            operation = "/";
            func = (x, y) => x / y;
        }
        public override Function Derivative()
        {
            return new Divide(new Subtract(new Multiply(Left.Derivative(), Right), new Multiply(Left, Right.Derivative())), new Multiply(Right, Right));
        }
    }
}

using p2022_Koba_B_O_Ind_3._3.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3New.FunctionsNew
{
    public delegate double BinaryDelegate(double x1, double x2);
    public abstract class Binary : Function
    {
        protected Function Left, Right;
        protected string operation = "";
        protected BinaryDelegate func;
        public Binary(Function l, Function r)
        {
            Left = l;
            Right = r;
        }
        public override double Calc(double x)
        {
            return func(Left.Calc(x), Right.Calc(x));
        }
        public override string ToString()
        {
            return "(" + Left.ToString() + ")" + operation + "(" + Right.ToString() + ")";
        }
    }
}

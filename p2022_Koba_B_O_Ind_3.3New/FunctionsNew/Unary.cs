using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    public delegate double UnaryDelegate(double x);

    public abstract class Unary : Function
    {
        protected Function arguments;
        protected UnaryDelegate function;

        public Unary(Function argument)
        {
            arguments = argument;
        }
        public override double Calc(double x)
        {
            return function((arguments.Calc(x) * Math.PI) / 180);
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}({arguments.ToString()})";
        }
    }
}

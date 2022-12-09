using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2022_Koba_B_O_Ind_3._3.Functions
{
    public class Constant : Function
    {
        private double value;
        public Constant(double value = 0)
        {
            this.value = value;
        }
        public override double Calc(double x)
        {
            return value;
        }
        public override string ToString()
        {
            return $"{value.ToString()}";
        }
        public override Function Derivative()
        {
            return new Constant(0.0);
        }
    }
}

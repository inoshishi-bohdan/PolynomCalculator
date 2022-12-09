using p2022_Koba_B_O_Ind_3._3.Functions;
using p2022_Koba_B_O_Ind_3._3New.FunctionsNew;
using System;

Console.WriteLine("MATH CLI Interface");
Console.WriteLine("-------------");
Constant constant1 = new Constant();
Console.WriteLine($"f(x)={constant1.ToString()}");
Console.WriteLine($"fun(0.0)={constant1.Calc(0.0)}");
Console.WriteLine($"Derivative={constant1.Derivative()}");
Console.WriteLine($"Derivative func(25)={constant1.Derivative().Calc(25)}");
Console.WriteLine("-------------");
Constant constant2 = new Constant(10);
Console.WriteLine($"f(x)={constant2.ToString()}");
Console.WriteLine($"fun(50)={constant2.Calc(50)}");
Console.WriteLine($"Derivative={constant2.Derivative()}");
Console.WriteLine($"Derivative func(2)={constant2.Derivative().Calc(2)}");
Console.WriteLine("-------------");
Constant constant3 = new Constant(2);
Console.WriteLine($"f(x)={constant3.ToString()}");
Console.WriteLine($"fun(2)={constant3.Calc(2)}");
Console.WriteLine($"Derivative={constant3.Derivative()}");
Console.WriteLine($"Derivative func(50)={constant3.Derivative().Calc(50)}");
Console.WriteLine("-------------");
Arguments arguments1 = new Arguments();
Console.WriteLine($"f(x)={arguments1.ToString()}");
Console.WriteLine($"fun(60)={arguments1.Calc(60)}");
Console.WriteLine($"Derivative={arguments1.Derivative()}");
Console.WriteLine($"Derivative func(60)={arguments1.Derivative().Calc(60)}");
Console.WriteLine("-------------");
Arguments arguments2 = new Arguments();
Console.WriteLine($"f(x)={arguments2.ToString()}");
Console.WriteLine($"fun(30)={arguments2.Calc(30)}");
Console.WriteLine($"Derivative={arguments2.Derivative()}");
Console.WriteLine($"Derivative func(30)={arguments2.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Multiply mult = new Multiply(new Constant(5), new Arguments());
Console.WriteLine($"f(x)={mult.ToString()}");
Console.WriteLine($"fun(60)={mult.Calc(60)}");
Console.WriteLine($"Derivative={mult.Derivative()}");
Console.WriteLine($"Derivative func(60)={mult.Derivative().Calc(60)}");
Console.WriteLine("-------------");
Sin sin1 = new Sin(new Arguments());
Console.WriteLine($"f(x)={sin1.ToString()}");
Console.WriteLine($"fun(30)={sin1.Calc(30)}");
Console.WriteLine($"Derivative={sin1.Derivative()}");
Console.WriteLine($"Derivative func(30)={sin1.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Sin sin2 = new Sin(new Arguments());
Console.WriteLine($"f(x)={sin2.ToString()}");
Console.WriteLine($"fun(60)={sin2.Calc(60)}");
Console.WriteLine($"Derivative={sin2.Derivative()}");
Console.WriteLine($"Derivative func(60)={sin2.Derivative().Calc(60)}");
Console.WriteLine("-------------");
Sin sin3 = new Sin(new Multiply(new Constant(1), new Arguments()));
Console.WriteLine($"f(x)={sin3.ToString()}");
Console.WriteLine($"fun(30)={sin3.Calc(30)}");
Console.WriteLine($"Derivative={sin3.Derivative()}");
Console.WriteLine($"Derivative func(30)={sin3.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Sin sin4 = new Sin(new Multiply(new Constant(2), new Arguments()));
Console.WriteLine($"f(x)={sin4.ToString()}");
Console.WriteLine($"fun(30)={sin4.Calc(30)}");
Console.WriteLine($"Derivative={sin4.Derivative()}");
Console.WriteLine($"Derivative func(30)={sin4.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Sin sin5 = new Sin(new Multiply(new Constant(3), new Arguments()));
Console.WriteLine($"f(x)={sin5.ToString()}");
Console.WriteLine($"fun(15)={sin5.Calc(15)}");
Console.WriteLine($"Derivative={sin5.Derivative()}");
Console.WriteLine($"Derivative func(15)={sin5.Derivative().Calc(15)}");
Console.WriteLine("-------------");
Cos cos1 = new Cos(new Arguments());
Console.WriteLine($"f(x)={cos1.ToString()}");
Console.WriteLine($"fun(30)={cos1.Calc(30)}");
Console.WriteLine($"Derivative={cos1.Derivative()}");
Console.WriteLine($"Derivative func(30)={cos1.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Cos cos2 = new Cos(new Arguments());
Console.WriteLine($"f(x)={cos2.ToString()}");
Console.WriteLine($"fun(60)={cos2.Calc(60)}");
Console.WriteLine($"Derivative={cos2.Derivative()}");
Console.WriteLine($"Derivative func(60)={cos2.Derivative().Calc(60)}");
Console.WriteLine("-------------");
Cos cos3 = new Cos(new Multiply(new Constant(1), new Arguments()));
Console.WriteLine($"f(x)={cos3.ToString()}");
Console.WriteLine($"fun(30)={cos3.Calc(30)}");
Console.WriteLine($"Derivative={cos3.Derivative()}");
Console.WriteLine($"Derivative func(30)={cos3.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Cos cos4 = new Cos(new Multiply(new Constant(2), new Arguments()));
Console.WriteLine($"f(x)={cos4.ToString()}");
Console.WriteLine($"fun(30)={cos4.Calc(30)}");
Console.WriteLine($"Derivative={cos4.Derivative()}");
Console.WriteLine($"Derivative func(30)={cos4.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Cos cos5 = new Cos(new Subtract(new Multiply(new Constant(3), new Arguments()), new Constant(1)));
Console.WriteLine($"f(x)={cos5.ToString()}");
Console.WriteLine($"fun(15)={cos5.Calc(15)}");
Console.WriteLine($"Derivative={cos5.Derivative()}");
Console.WriteLine($"Derivative func(15)={cos5.Derivative().Calc(15)}");
Console.WriteLine("-------------");
Tan tan1 = new Tan(new Arguments());
Console.WriteLine($"f(x)={tan1.ToString()}");
Console.WriteLine($"fun(30)={tan1.Calc(30)}");
Console.WriteLine($"Derivative={tan1.Derivative()}");
Console.WriteLine($"Derivative func(30)={tan1.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Tan tan2 = new Tan(new Arguments());
Console.WriteLine($"f(x)={tan2.ToString()}");
Console.WriteLine($"fun(60)={tan2.Calc(60)}");
Console.WriteLine($"Derivative={tan2.Derivative()}");
Console.WriteLine($"Derivative func(60)={tan2.Derivative().Calc(60)}");
Console.WriteLine("-------------");
Tan tan3 = new Tan(new Multiply(new Constant(1), new Arguments()));
Console.WriteLine($"f(x)={tan3.ToString()}");
Console.WriteLine($"fun(30)={tan3.Calc(30)}");
Console.WriteLine($"Derivative={tan3.Derivative()}");
Console.WriteLine($"Derivative func(30)={tan3.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Tan tan4 = new Tan(new Multiply(new Constant(2), new Arguments()));
Console.WriteLine($"f(x)={tan4.ToString()}");
Console.WriteLine($"fun(30)={tan4.Calc(30)}");
Console.WriteLine($"Derivative={tan4.Derivative()}");
Console.WriteLine($"Derivative func(30)={tan4.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Tan tan5 = new Tan(new Subtract(new Multiply(new Constant(3), new Arguments()), new Constant(1)));
Console.WriteLine($"f(x)={tan5.ToString()}");
Console.WriteLine($"fun(15)={tan5.Calc(15)}");
Console.WriteLine($"Derivative={tan5.Derivative()}");
Console.WriteLine($"Derivative func(15)={tan5.Derivative().Calc(15)}");
CTan ctan1 = new CTan(new Arguments());
Console.WriteLine($"f(x)={ctan1.ToString()}");
Console.WriteLine($"fun(30)={ctan1.Calc(30)}");
Console.WriteLine($"Derivative={ctan1.Derivative()}");
Console.WriteLine($"Derivative func(30)={ctan1.Derivative().Calc(30)}");
Console.WriteLine("-------------");
CTan ctan2 = new CTan(new Arguments());
Console.WriteLine($"f(x)={ctan2.ToString()}");
Console.WriteLine($"fun(60)={ctan2.Calc(60)}");
Console.WriteLine($"Derivative={ctan2.Derivative()}");
Console.WriteLine($"Derivative func(60)={ctan2.Derivative().Calc(60)}");
Console.WriteLine("-------------");
CTan ctan3 = new CTan(new Multiply(new Constant(1), new Arguments()));
Console.WriteLine($"f(x)={ctan3.ToString()}");
Console.WriteLine($"fun(30)={ctan3.Calc(30)}");
Console.WriteLine($"Derivative={ctan3.Derivative()}");
Console.WriteLine($"Derivative func(30)={ctan3.Derivative().Calc(30)}");
Console.WriteLine("-------------");
CTan ctan4 = new CTan(new Multiply(new Constant(2), new Arguments()));
Console.WriteLine($"f(x)={ctan4.ToString()}");
Console.WriteLine($"fun(30)={ctan4.Calc(30)}");
Console.WriteLine($"Derivative={ctan4.Derivative()}");
Console.WriteLine($"Derivative func(30)={ctan4.Derivative().Calc(30)}");
Console.WriteLine("-------------");
CTan ctan5 = new CTan(new Subtract(new Multiply(new Constant(3), new Arguments()), new Constant(1)));
Console.WriteLine($"f(x)={ctan5.ToString()}");
Console.WriteLine($"fun(15)={ctan5.Calc(15)}");
Console.WriteLine($"Derivative={ctan5.Derivative()}");
Console.WriteLine($"Derivative func(15)={ctan5.Derivative().Calc(15)}");
Exp exp1 = new Exp(new Constant(2));
Console.WriteLine($"f(x)={exp1.ToString()}");
Console.WriteLine($"fun(30)={exp1.Calc(30)}");
Console.WriteLine($"Derivative={exp1.Derivative()}");
Console.WriteLine($"Derivative func(30)={exp1.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Exp exp2 = new Exp(new Arguments());
Console.WriteLine($"f(x)={exp2.ToString()}");
Console.WriteLine($"fun(10)={exp2.Calc(10)}");
Console.WriteLine($"Derivative={exp2.Derivative()}");
Console.WriteLine($"Derivative func(10)={exp2.Derivative().Calc(10)}");
Console.WriteLine("-------------");
Exp exp3 = new Exp(new Multiply(new Constant(1), new Arguments()));
Console.WriteLine($"f(x)={exp3.ToString()}");
Console.WriteLine($"fun(10)={exp3.Calc(10)}");
Console.WriteLine($"Derivative={exp3.Derivative()}");
Console.WriteLine($"Derivative func(30)={exp3.Derivative().Calc(30)}");
Console.WriteLine("-------------");
Exp exp4 = new Exp(new Multiply(new Constant(2), new Arguments()));
Console.WriteLine($"f(x)={exp4.ToString()}");
Console.WriteLine($"fun(7)={exp4.Calc(7)}");
Console.WriteLine($"Derivative={exp4.Derivative()}");
Console.WriteLine($"Derivative func(7)={exp4.Derivative().Calc(7)}");
Console.WriteLine("-------------"); // залишилось потестити тільки поліноми складні
                                    // 




//Console.WriteLine("-------------");
/*Add add2 = new Add(new Sin(new Multiply(new Constant(3), new Arguments())), new Arguments());
Console.WriteLine($"f(x)={add2.ToString()}");
Console.WriteLine($"fun(19)={add2.Calc(19)}");
Console.WriteLine($"Derivative={add2.Derivative()}");
Console.WriteLine($"Derivative func(19)={add2.Derivative().Calc(19)}");
Add add3 = new Add(new Sin(new Multiply(new Constant(3), new Arguments())), new Arguments());
Console.WriteLine($"f(x)={add3.ToString()}");
Console.WriteLine($"fun(21)={add3.Calc(21)}");
Console.WriteLine($"Derivative={add3.Derivative()}");
Console.WriteLine($"Derivative func(21)={add3.Derivative().Calc(21)}");
Console.WriteLine("-------------");*/
Add add1 = new Add(new Sin(new Multiply(new Constant(3), new Arguments())), new Arguments());
Console.WriteLine($"f(x)={add1.ToString()}");
Console.WriteLine($"fun(20)={add1.Calc(20)}");
Console.WriteLine($"Derivative={add1.Derivative()}");
Console.WriteLine($"Derivative func(20)={add1.Derivative().Calc(20)}");
Console.WriteLine($"Derivative Derivative func(20)={add1.Derivative().Derivative()}");
Console.WriteLine($"Derivative Derivative func(20)={add1.Derivative().Derivative().Calc(20)}");
Console.WriteLine(GetRoot(function_result: 20.866025403784437, function: add1, start_of_interval: 10, end_of_interval: 25, precision: 0.000001));

Subtract subt1 = new Subtract(new Subtract(new CTan(new Subtract(new Multiply(new Constant(3), new Arguments()), new Constant(1))), new Exp(new Constant(2))), new Constant(10));
Console.WriteLine($"f(x)={subt1.ToString()}");
Console.WriteLine($"fun(30)={subt1.Calc(30)}");
Console.WriteLine($"Derivative={subt1.Derivative()}");
Console.WriteLine($"Derivative func(30)={subt1.Derivative().Calc(30)}");
Console.WriteLine(GetRoot(function_result: -17.37160103400243, function: subt1, start_of_interval: 20, end_of_interval: 50, precision: 0.000001));
Console.WriteLine("-------------");

Console.WriteLine("-------------");
Divide div1 = new Divide(new Cos(new Multiply(new Constant(2), new Arguments())), new Exp(new Multiply(new Constant(2), new Arguments())));
Console.WriteLine($"f(x)={div1.ToString()}");
Console.WriteLine($"fun(10)={div1.Calc(10)}");
Console.WriteLine($"Derivative={div1.Derivative()}");
Console.WriteLine($"Derivative func(10)={div1.Derivative().Calc(10)}");
Console.WriteLine(GetRoot(function_result: 1.9368508493116574E-09, function: div1, start_of_interval: 0, end_of_interval: 35, precision: 0.000001));
Console.ReadLine();
static double GetRoot(Function function, double function_result, double precision, double start_of_interval, double end_of_interval)
{
    Function new_func = new Subtract(function, new Constant(function_result));
    if (new_func.Calc(start_of_interval) * new_func.Calc(end_of_interval) > 0)
    {
        Console.WriteLine("no roots on the interval");
        return 0;
    }
    double mediator = 0;
    double start_of_isolation;
    double end_of_isolation;
    double func_start_of_isolation;
    double func_end_of_isolation;
    double func_mediator;
    start_of_isolation = start_of_interval;
    end_of_isolation= end_of_interval;
    int counter = 0;
    while (Math.Abs( end_of_isolation - start_of_isolation) >= precision)
    { 
        mediator = (start_of_isolation + end_of_isolation)/2;
        func_start_of_isolation = new_func.Calc(start_of_isolation);
        func_end_of_isolation = new_func.Calc(end_of_isolation);
        func_mediator= new_func.Calc(mediator);
        if (func_start_of_isolation == 0)
        { 
            mediator = start_of_isolation;
            break;
        }
        if (func_end_of_isolation == 0)
        { 
            mediator= end_of_isolation;
            break;
        }
        if (func_mediator == 0)
        {
            break;
        }
        else if (func_start_of_isolation * func_mediator < 0)
           end_of_isolation = mediator;
        else if(func_mediator * func_end_of_isolation < 0)
           start_of_isolation = mediator;
    }
    return mediator;
}
/*static List<(double, double)> GetIntervalsOfIsolation(Function function,  double start, double end)
{
    List<(double, double)> result = new List<(double, double)>();
    double res1;
    double res2;
    for (double i = start; i < end; i++)
    {
        res1 = function.Calc(i);
        res2 = function.Calc(i+1);
        if (res1 * res2 <= 0)
        {
            if (ExistRootOnIsolationInterval(function , (i, i + 1)) == true)
            {

            }
            result.Add((i, i + 1));
        }
    }
    return result;
}
static bool ExistRootOnIsolationInterval(Function function, (double, double) isolation_interval)
{
    for (double i = isolation_interval.Item1 ; i < isolation_interval.Item2; i++)
    {
        if(function.Derivative().Calc(i) < 0)
            return false;
    }
    return true;
}*/
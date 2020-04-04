using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {


        double x1, x2;
        //if (a!=0 && (b*b-c)>0)
        //{
            x1 = (-b + Math.Sqrt(b * b - (4*a*c))) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4*a*c)) / (2 * a); 
            return Tuple.Create( x1, x2);
        //}
    }

    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
    }
}

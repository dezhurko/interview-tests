using System;

namespace ConsoleApp1
{
    public interface IValue
    {
        double X { get; set; }
    }

    public struct Value : IValue
    {
        public double X { get; set; }

        public Value(double x, double y)
        {
            X = x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Value(1, 1);
            Console.WriteLine($"{r1.X}");

            var r2 = r1;
            r2.X = 2;
            Console.WriteLine($"{r1.X}");

            SetX3(r2);
            Console.WriteLine($"{r2.X}");

            SetX4(ref r2);
            Console.WriteLine($"{r2.X}");
            
            SetX5(in r2);
            Console.WriteLine($"{r2.X}");

            r2 = (Value)SetX6(r2);
            Console.WriteLine($"{r2.X}");
        }

        private static void SetX3(Value r)
        {
            r.X = 3;
        }
        
        private static void SetX4(ref Value r)
        {
            r.X = 4;
        }
        
        private static void SetX5(in Value r)
        {
            r.X = 5;
        }
        
        private static IValue SetX6(IValue r)
        {
            var rr = (Value)r;
            rr.X = 6;
            return r;
        }
    }
}
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

        public Value(double x)
        {
            X = x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var v = new Value(1);        

            SetX(v);
            Console.WriteLine($"{v.X}");

            SetWithRef(ref v);
            Console.WriteLine($"{v.X}");

            SetWithIn(in v);
            Console.WriteLine($"{v.X}");

            SetWithInterface(v);
            Console.WriteLine($"{v.X}");

            var vi = (IValue)v;
            SetWithInterface(vi);
            Console.WriteLine($"{v.X}");
            Console.WriteLine($"{vi.X}");
        }

        private static void SetX(Value v)
        {
            v.X = 3;
        }
        
        private static void SetWithRef(ref Value v)
        {
            v.X = 4;
        }
        
        private static void SetWithIn(in Value v)
        {
            v.X = 5;
        }
        
        private static void SetWithInterface(IValue v)
        {
            v.X = 6;
        }
    }
}
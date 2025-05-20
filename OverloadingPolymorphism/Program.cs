namespace OverloadingPolymorphism
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            int c = x + y;
            return c;
        }

        public int Add(int x, int y, int z)
        {
            int d = x + y + z;
            return d;
        }

        public double Add(double x, double y)
        {
            double z = x + y;
            return z;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(6, 7));
            Console.WriteLine(calc.Add(10, 12, 30));
            Console.WriteLine(calc.Add(20.0, 30.0));

        }
    }
}

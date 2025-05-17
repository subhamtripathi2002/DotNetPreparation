namespace Delegates
{
    public delegate void Calculater(int x, int y);

    class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);

        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);

        }

        public static void Main(string[] args)
        {
            Calculater calc = new Calculater(Add);
            Calculater multi = new Calculater(Mul);

            calc(20, 30);
            multi(10, 30);
        }
    }
}

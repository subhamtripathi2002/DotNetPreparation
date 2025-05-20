namespace OverridePolymorphism
{
    class Car
    {
        public virtual void Noise()
        {
            Console.WriteLine("Car makes a noise");
        }
    }

    class Nexon : Car
    {
        public override void Noise()
        {
            Console.WriteLine("Horn");
        }
    }

    class Scorpio : Car
    {
        public override void Noise()
        {
            Console.WriteLine("Black");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Nexon();
            car.Noise();  
            car = new Scorpio();
            car.Noise();  
        }
    }
}

namespace MultilevelInheritance
{
    class Vechile
    {
        public void Company()
        {
            Console.WriteLine("Company name TATA");
        }
        
    }

    class Car : Vechile
    {
        public void Tata()
        {
            Console.WriteLine("Car is Nexon");
        }
    }

    class Nexon : Car
    {
        public void Model()
        {
            Console.WriteLine("Model is Nexon top variant");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Nexon myCar = new Nexon();

            myCar.Company();
            myCar.Tata();
            myCar.Model();

        }
    }
}

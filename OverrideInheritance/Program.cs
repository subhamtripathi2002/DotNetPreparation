namespace OverrideInheritance
{

    class Books
    {
        public virtual void Subject()
        {
            Console.WriteLine("College Books");
        }
    }

    class Maths : Books
    {
        public override void Subject()
        {
            Console.WriteLine("Maths question solved");
        }
    }

    class Physics : Books
    {
        public override void Subject()
        {
            Console.WriteLine("Science problem solved");
        }
    }
     class Program
    {
        public static void Main(string[] args)
        {
            Books book1 = new Maths();
            Books book2 = new Physics();

            book1.Subject();
            book2.Subject();
        }
    }
}

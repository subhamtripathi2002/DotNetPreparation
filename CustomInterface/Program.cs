namespace CustomInterface
{
    public interface Animal
    {
        void Speak(); 
    }

    public class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    class Program
    {
        public static void Main()
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.Speak(); 
            myCat.Speak();  
        }
    }

}

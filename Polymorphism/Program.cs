namespace Polymorphism
{
    class Animal   
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says");
        }
    }

    class Dog : Animal  
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  
            Animal myPig = new Pig();  
            Animal myDog = new Dog();  

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}

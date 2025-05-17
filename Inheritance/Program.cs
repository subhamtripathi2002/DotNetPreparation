using System;

namespace Inheritance
{
     class Vehicle
    {
        public string brand = "Ford";  
        public void bmw()             
        {
            Console.WriteLine("car");
        }
    }

    class Car : Vehicle 
    {
        public string modelName = "EcoSport";  
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();

            
            myCar.bmw();

            
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}

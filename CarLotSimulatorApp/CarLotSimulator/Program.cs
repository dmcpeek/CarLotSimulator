using System;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Default Constructor - Object Dot Notation
            Car myCar1 = new Car();

            myCar1.Year = 1955;
            myCar1.Make = "BMW";
            myCar1.Model = "Isetta";
            myCar1.EngineNoise = "putt-putt-putt";
            myCar1.HonkNoise = "a sickly whine";
            myCar1.IsDriveable = false;
            lot.Cars.Add(myCar1);

            var engineSound1 = myCar1.EngineNoise;
            var honk1 = myCar1.HonkNoise;
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            Console.WriteLine($"Year: {myCar1.Year}");
            Console.WriteLine($"Make: {myCar1.Make}");
            Console.WriteLine($"Model: {myCar1.Model}");
            Console.WriteLine($"Engine noise: {engineSound1}");
            Console.WriteLine($"Horn sound: {honk1}");
            Console.WriteLine($"Can be driven: {myCar1.IsDriveable}");
            Console.WriteLine();
            Console.WriteLine();

            //Custom Constructor - Object Initializer Syntax
            Car myCar2 = new Car()
            {
                Year = 2017,
                Make = "Toyota",
                Model = "RAV4",
                EngineNoise = "Shhhhh",
                HonkNoise = "toot-toot",
                IsDriveable = true
            };
            lot.Cars.Add(myCar2);

            var engineSound2 = myCar2.EngineNoise;
            var honk2 = myCar2.HonkNoise;
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            Console.WriteLine($"Year: {myCar2.Year}");
            Console.WriteLine($"Make: {myCar2.Make}");
            Console.WriteLine($"Model: {myCar2.Model}");
            Console.WriteLine($"Engine noise: {engineSound2}");
            Console.WriteLine($"Horn sound: {honk2}");
            Console.WriteLine($"Can be driven: {myCar2.IsDriveable}");
            Console.WriteLine();
            Console.WriteLine();

            //Custom Constructor - Custom Cunstructor
            Car myCar3 = new Car(2023, "Bugatti", "Chiron Super Sport 300+", "Vroom-Vroom", "uh, what's the point of a horn if you're going 300+ MPH?", true );
            lot.Cars.Add(myCar3);

            var engineSound3 = myCar3.EngineNoise;
            var honk3 = myCar3.HonkNoise;
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            Console.WriteLine($"Year: {myCar3.Year}");
            Console.WriteLine($"Make: {myCar3.Make}");
            Console.WriteLine($"Model: {myCar3.Model}");
            Console.WriteLine($"Engine noise: {engineSound3}");
            Console.WriteLine($"Horn sound: {honk3}");
            Console.WriteLine($"Can be driven: {myCar3.IsDriveable}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Workin' at the car lot");

            foreach (var car in lot.Cars)
            {
                var engineSound = car.EngineNoise;
                var honk = car.HonkNoise;
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Engine noise: {engineSound}");
                Console.WriteLine($"Horn sound: {honk}");
                Console.WriteLine($"Can be driven: {car.IsDriveable}");
                Console.WriteLine();
            }
        }
    }
}

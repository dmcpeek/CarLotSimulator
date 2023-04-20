using System;

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

            Console.Write($"My {myCar1.Year} {myCar1.Make} {myCar1.Model}'s engine goes {myCar1.EngineNoise}");
            Console.Write($" and the horn sounds like {myCar1.HonkNoise}. It is {myCar1.IsDriveable} that it can be driven.");
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

            Console.Write($"My {myCar2.Year} {myCar2.Make} {myCar2.Model}'s engine goes {myCar2.EngineNoise}");
            Console.Write($" and the horn sounds like {myCar2.HonkNoise}. It is {myCar2.IsDriveable} that it can be driven.");

            Console.WriteLine();

            //Custom Constructor
            Car myCar3 = new Car(2023, "Bugatti", "Chiron Super Sport 300+", "Vroom-Vroom", "uh, what's the point of a horn if you're going 300+ MPH?", true );
            lot.Cars.Add(myCar3);

            Console.Write($"My {myCar3.Year} {myCar3.Make} {myCar3.Model}'s engine goes {myCar3.EngineNoise}");
            Console.Write($" and the horn sounds like {myCar3.HonkNoise}. It is {myCar3.IsDriveable} that it can be driven.");
            Console.WriteLine();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("Workin' at the car lot");
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($" Year: {car.Year} Make: {car.Make} Model: {car.Model} Engine Noise: {car.EngineNoise} Honk Noise: {car.HonkNoise} Driveable: {car.IsDriveable}");
            }
        }
    }
}

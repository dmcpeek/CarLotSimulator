using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        //Defaullt or empty constructor
        public Car()
        {
        }

        //Constructor
        public Car(int year,
                   string make,
                   string model, 
                   string engineNoise, 
                   string honkNoise, 
                   bool isDriveable)

        {
            Year = year;
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            IsDriveable = isDriveable;
        }

        //Capital Year comes from here. Lower case year comes from the constructor.
        //These are properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.Write($"{engineNoise}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.Write($"{honkNoise}");
        }

        public void CanItBeDriven(bool driveIt)
        {
            if (driveIt == true)
            {
                Console.Write("This car drives like a dream!");
            }
            else
                Console.Write("What was I thinking when I bought it!!!");
        }
    }
}
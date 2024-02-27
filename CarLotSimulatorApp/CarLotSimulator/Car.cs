using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    { 

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }
        
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine("Engine noise: " + engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine("Honk Noise: " + honkNoise);
        }
    }
}

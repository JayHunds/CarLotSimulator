using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

            Car car1 = new Car(2020, "Toyota", "Corolla", "Vroom", "Beep", true);
            Console.WriteLine($"Number of cars in the car lot {CarLot._numberOfCars}");
            Car car2 = new Car(2017, "Honda", "Civic", "Rumble", "Honk", true);
            Car car3 = new Car(1925, "Ford", "Model T", "Growl", "Toot", false);

            carLot.AddCar(car1);
            carLot.AddCar(car2);
            carLot.AddCar(car3);
            
            foreach (var car in carLot.Cars) 
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}, Engine Noise: {car.EngineNoise}, Honk Noise: {car.HonkNoise}");
            }
           


        }
    }
}

using System;

namespace PrototypePattern
{
    // Абстрактний клас, який визначає метод Clone(), який повертає копію об'єкта
    abstract class Prototype
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public abstract Prototype Clone();
    }

    // Конкретний клас, який успадковується від абстрактного класу Prototype та реалізує метод Clone()
    class CarPrototype : Prototype
    {
        public override Prototype Clone()
        {
            // Використання поверхневого копіювання (shallow copy) для створення нового об'єкта-прототипу
            return (Prototype)this.MemberwiseClone();
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            // Створення об'єкта-прототипу
            CarPrototype carPrototype = new CarPrototype();
            carPrototype.Brand = "Toyota";
            carPrototype.Model = "Camry";
            carPrototype.Year = 2020;

            // Створення нового автомобіля на основі об'єкта-прототипу
            CarPrototype newCar = (CarPrototype)carPrototype.Clone();
            newCar.Year = 2021;

            Console.WriteLine("Prototype: {0} {1} {2}", carPrototype.Brand, carPrototype.Model, carPrototype.Year);
            Console.WriteLine("New car: {0} {1} {2}", newCar.Brand, newCar.Model, newCar.Year);
        }
    }
}

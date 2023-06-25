using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal interface IVehicle
    {
        // Declare the methods
        void Start();
        void Accelerate(int speed);
        void Brake();
    }

    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The car starts with a key.");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine($"The car accelerates to {speed} km/h.");
        }

        public void Brake()
        {
            Console.WriteLine("The car brakes with a pedal.");
        }
    }

    internal class Motorcycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The motorcycle starts with a button.");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine($"The motorcycle accelerates to {speed} km/h.");
        }

        public void Brake()
        {
            Console.WriteLine("The motorcycle brakes with a lever.");
        }
    }

}

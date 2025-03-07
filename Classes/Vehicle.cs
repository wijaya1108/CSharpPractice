using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class Vehicle
    {
        public int DoorCount { get; init; }
        public int WheelCount { get; init; }

        public void OpenDoors()
        {
            Console.WriteLine($"{GetType().Name} opens {DoorCount} doors and it has {WheelCount} wheels");
        }
    }

    public class Automobile : Vehicle
    {
        
    }

    public class Car : Automobile
    {

    }

    public class Van : Automobile
    {

    }

    public class Plane : Vehicle
    {

    }

    public class Bike : Vehicle
    {
        public Bike()
        {
            DoorCount = 0;
            WheelCount = 2;
        }
    }

}

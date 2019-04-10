using Interfaces;
using System;

namespace InterfaceImplementations
{
    public class Battery : IBattery
    {
        public Battery(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; }

        public virtual void Charge()
        {
            Console.WriteLine("Charging");
        }
    }
}

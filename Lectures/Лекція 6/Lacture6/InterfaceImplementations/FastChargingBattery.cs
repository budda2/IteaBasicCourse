using System;

namespace InterfaceImplementations
{
    public class FastChargingBattery : Battery
    {
        public FastChargingBattery(int capacity)
            : base(capacity)
        {
        }

        public override void Charge()
        {
            Console.WriteLine("Fast charging");
        }
    }
}

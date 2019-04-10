using InterfaceImplementations;
using Interfaces;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IBattery battery = new Battery(5000);
            IBattery fastBattery = new FastChargingBattery(12000);
            
            var batteryCharger = new BatteryCharger(4000);
            batteryCharger.ChargeBattery(battery);
            batteryCharger.ChargeBattery(fastBattery);

            Console.ReadLine();
        }
    }
}

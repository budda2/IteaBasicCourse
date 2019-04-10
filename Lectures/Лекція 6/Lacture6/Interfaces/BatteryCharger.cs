namespace Interfaces
{
    public class BatteryCharger
    {
        private int _power;
        public BatteryCharger(int power)
        {
            _power = power;
        }

        public void ChargeBattery(IBattery battery)
        {
            for (int i = 0; i < _power / battery.Capacity; i++)
                battery.Charge();
        }
    }
}

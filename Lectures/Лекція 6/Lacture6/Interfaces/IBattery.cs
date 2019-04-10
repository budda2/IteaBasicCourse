namespace Interfaces
{
    public interface IBattery
    {
        int Capacity { get; }
        void Charge();
    }
}

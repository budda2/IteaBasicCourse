using System;

namespace Zoo
{
    public class Visitor : Person
    {
        public Visitor(int age, string name) : base(age, name)
        {
        }

        public override void GoToTheZoo()
        {
            base.GoToTheZoo();
            Console.WriteLine("Horray");
        }

        public void Observe(Animal animal)
        {
            Console.WriteLine("Such a nice animal");
        }
    }
}

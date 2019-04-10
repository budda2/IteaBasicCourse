using System;

namespace Zoo
{
    public class Animal
    {
        public virtual void Eat(Food food)
        {
            Console.WriteLine("Food");
        }
    }
}

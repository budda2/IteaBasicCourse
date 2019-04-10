using System;

namespace Zoo
{
    public class Bird : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine($"Yea, foor with {food.Callories} calories is good");
        }
    }
}

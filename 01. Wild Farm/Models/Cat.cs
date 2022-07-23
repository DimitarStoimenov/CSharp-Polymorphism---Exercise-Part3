using System;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override string Sound()
        {
            return "Meow";
        }

        public override void Eat(IFood food)
        {
            if (!(food is Vegetable || food is Meat))
            {
                ExeptionMessageNotEet(this, food);
                
            }

            this.Weight += food.Quantity * 0.30;
            FoodEaten += food.Quantity;
        }
    }
}

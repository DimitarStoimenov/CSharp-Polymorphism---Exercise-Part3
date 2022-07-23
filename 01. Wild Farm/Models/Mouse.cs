namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string Sound()
        {
            return  "Squeak";
        }
        public override void Eat(IFood food)
        {
            if (!(food is Vegetable || food is Fruit))
            {
                ExeptionMessageNotEet(this, food);

                
            }
            this.Weight += food.Quantity * 0.10;
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

        }
    }
}

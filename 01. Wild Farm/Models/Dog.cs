namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string Sound()
        {
            return  "Woof!";
        }
        public override void Eat(IFood food)
        {
            if (!(food is Meat))
            {
                
                ExeptionMessageNotEet(this, food);
            }
            this.Weight += food.Quantity * 0.40;
            FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

        }
    }
}

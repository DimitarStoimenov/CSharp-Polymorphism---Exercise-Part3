namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
          : base(name, weight, livingRegion, breed)
        {
        }

        public override string Sound()
        {
            return  "ROAR!!!";
        }
        public override void Eat(IFood food)
        {
            if (!(food is Meat))
            {
                ExeptionMessageNotEet(this, food);
            }
            this.Weight += food.Quantity * 1.00;
            FoodEaten += food.Quantity;
        }
    }
}

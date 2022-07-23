namespace WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }

        public override void Eat(IFood food)
        {
            if (!(food is Meat))
            {
                ExeptionMessageNotEet(this, food);
            }
            FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.25;
        }

        public override string Sound()
        {
            return  "Hoot Hoot";
        }
    }
}

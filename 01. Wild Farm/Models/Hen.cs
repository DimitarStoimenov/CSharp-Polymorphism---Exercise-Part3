namespace WildFarm.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            this.Weight += food.Quantity * 0.35;
            FoodEaten += food.Quantity;
        }

        public override string Sound()
        {
            return  "Cluck";
        }
    }
}

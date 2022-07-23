namespace WildFarm
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public string Sound();
        public void Eat(IFood food);

        
        
    }
}

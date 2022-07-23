using System;
using System.Collections.Generic;
using WildFarm.Models;

namespace WildFarm
{


    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IAnimal> animals = new List<IAnimal>();

            while (command != "End")
            {
                IAnimal animal = null;
                string[] animalInfo = command.Split();
                string typeAnimal = animalInfo[0];
                string nameAnimal = animalInfo[1];
                double weightAnimal = double.Parse(animalInfo[2]);
                try
                {
                    if (typeAnimal == "Hen" || typeAnimal == "Owl")
                    {
                        double wings = double.Parse(animalInfo[3]);
                        if (typeAnimal == "Hen")
                        {
                            animal = new Hen(nameAnimal, weightAnimal, wings);
                        }

                        else
                        {
                            animal = new Owl(nameAnimal, weightAnimal, wings);
                        }

                    }
                    else if (typeAnimal == "Cat" || typeAnimal == "Tiger")
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];


                        if (typeAnimal == "Cat")
                        {
                            animal = new Cat(nameAnimal, weightAnimal, livingRegion, breed);
                        }
                        else
                        {
                            animal = new Tiger(nameAnimal, weightAnimal, livingRegion, breed);
                        }
                    }
                    else if (typeAnimal == "Mouse" || typeAnimal == "Dog")
                    {
                        string livingRegion = animalInfo[3];

                        if (typeAnimal == "Mouse")
                        {
                            animal = new Mouse(nameAnimal, weightAnimal, livingRegion);
                        }
                        else
                        {
                            animal = new Dog(nameAnimal, weightAnimal, livingRegion);
                        }
                    }

                    Console.WriteLine(animal.Sound());
                    animals.Add(animal);


                    string[] eatInfo = Console.ReadLine().Split();
                    string typeFood = eatInfo[0];
                    int quantityInfo = int.Parse(eatInfo[1]);

                    IFood food = null;

                    if (typeFood == "Meat")
                    {

                        food = new Meat(quantityInfo);
                    }
                    else if (typeFood == "Vegetable")
                    {
                        food = new Vegetable(quantityInfo);

                    }
                    else if (typeFood == "Seeds")
                    {
                        food = new Seeds(quantityInfo);

                    }
                    else if (typeFood == "Fruit")
                    {
                        food = new Fruit(quantityInfo);

                    }
                    animal.Eat(food);

                    
                }

                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
                command = Console.ReadLine();
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}


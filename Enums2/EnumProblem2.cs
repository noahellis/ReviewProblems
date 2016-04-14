using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class EnumProblem2
    {
        private List<Animal> animalList = new List<Animal>();
        public EnumProblem2()
        {
            AddAnimalList();
        }
        internal List<Animal> AnimalList
        {
            get
            {
                return animalList;
            }

            set
            {
                animalList = value;
            }
        }

        public void AddAnimalList()
        {
            AnimalList.Add(new Dog("fido", 4, DogBreed.doberman));
            AnimalList.Add(new Bird("polly", 3, BirdBreed.dove));
            AnimalList.Add(new Rabbit("bugs", 60, RabbitBreed.volcano));
            AnimalList.Add(new Cat("sylvester", 60, CatBreed.tabby));
            AnimalList.Add(new Bird("tweety", 60, BirdBreed.birdOfParadise));

        }
        public void PrintAnimals()
        {
            
            foreach(Animal animal in AnimalList)
            {
                
                if (animal is Dog)
                {
                    Console.WriteLine("Dog: {0}, {1}, {2}", animal.name, animal.age, ((Dog)animal).DogBreed.ToString());
                }
                else if (animal is Cat)
                {
                    Console.WriteLine("Cat: {0}, {1}, {2}", animal.name, animal.age, ((Cat)animal).CatBreed.ToString());
                }
                else if (animal is Bird)
                {
                    Console.WriteLine("Bird: {0}, {1}, {2}", animal.name, animal.age, ((Bird)animal).BirdBreed.ToString());
                }
                else if (animal is Rabbit)
                {
                    Console.WriteLine("Rabbit: {0}, {1}, {2}", animal.name, animal.age, ((Rabbit)animal).RabbitBreed.ToString());
                }

            }
        }
        
    }
}

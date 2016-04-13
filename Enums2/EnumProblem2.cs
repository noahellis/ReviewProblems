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
                Console.WriteLine(animal.name, animal.age, ) 
            }
        }
        
    }
}

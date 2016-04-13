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
            AnimalList.Add(new Animal("fido", 4, Dog.doberman));
            AnimalList.Add(new Animal("polly", 3, Bird.dove));
            AnimalList.Add(new Animal("bugs", 60, Rabbit.volcano));
            AnimalList.Add(new Animal("sylvester", 60, Cat.tabby));
            AnimalList.Add(new Animal("tweety", 60, Bird.birdOfParadise));

        }
        public void PrintAnimals()
        {
            foreach(Animal animal in AnimalList)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Type of Animal: {2}", animal.name, animal.age, Dog.labradoodle.ToString());
            }
        }
        
    }
}

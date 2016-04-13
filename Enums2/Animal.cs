using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public enum DogBreed
    {
        labradoodle,
        rhodesianRidgeback,
        doberman
    }
    public enum CatBreed
    {
        tabby,
        siamese,
        callico
    }
    public enum RabbitBreed
    {
        pygmy,
        cottontail,
        volcano
    }
    public enum BirdBreed
    {
        parrot,
        dove,
        birdOfParadise
    }
    class Animal
    {
        public string name;
        public int age;
        public Animal(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public void AddAnimals()
        {

        }
    }
}

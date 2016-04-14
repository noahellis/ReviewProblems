using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Dog : Animal
    {
        public string name;
        public int age;
        public DogBreed DogBreed;
        public Dog(string Name, int Age, DogBreed dogBreed) :base (Name, Age)
        {
            name = Name;
            age = Age;
            DogBreed = dogBreed;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Bird : Animal
    {
        public string name;
        public int age;
        public BirdBreed BirdBreed;
        public Bird(string Name, int Age, BirdBreed birdBreed) : base(Name, Age)
        {
            name = Name;
            age = Age;
            birdBreed = BirdBreed;
        }
    }
}

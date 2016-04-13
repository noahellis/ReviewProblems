using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Cat : Animal
    {
        public string name;
        public int age;
        public CatBreed CatBreed;
        public Cat(string Name, int Age, CatBreed catBreed) : base(Name, Age)
        {
            name = Name;
            age = Age;
            catBreed = CatBreed;
        }
    }
}

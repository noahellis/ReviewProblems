using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Rabbit : Animal
    {
        public string name;
        public int age;
        public RabbitBreed RabbitBreed;
        public Rabbit(string Name, int Age, RabbitBreed rabbitBreed) : base(Name,Age)
        {
            name = Name;
            age = Age;
            rabbitBreed = RabbitBreed;
        }
    }
}

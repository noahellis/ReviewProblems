using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Person
    {
        static string firstName;
        static string lastName;
        static int age;
        static string birthday;
        static int addedAge = 12;

        public Person(string Birthday)
        {
            birthday = Birthday;
        }
        public Person()
        {

        }
        public Person (string FirstName, string LastName, int Age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }
        public static Person operator + (Person person, int age)
        {
            Person newPerson = new Person();
            age = age + addedAge;
            Console.WriteLine("New Person: {0}{1}, Age in {3} years: {4}", firstName, lastName, addedAge, age);
            return person;
        }

    }
}

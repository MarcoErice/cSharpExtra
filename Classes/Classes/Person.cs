using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    class Person
    {
        //string _name;
        //string _ssn;  // social security number.

        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //public void SetAge(int age)
        //{
        //    Age = age;
        //}
    }
}

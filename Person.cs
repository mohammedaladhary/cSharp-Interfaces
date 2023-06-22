using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Person
    {
        String name;
        readonly String username;
        int age;
        const int abc = 5;

        public Person(String name, String username, int age)
        {
            this.name = name;
            this.username = username;
            this.age = age;
        }

        public override string ToString()
        {
            return this.name + " " + this.username + " " + this.age;
        }
    }
}

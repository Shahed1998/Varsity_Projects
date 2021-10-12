using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    abstract class Person
    {
        private string name;
        private string dob;

        public Person() { }
        

        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public abstract void display();
    }
}

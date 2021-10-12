using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Employee : Person
    {
        public Account acc;

        public Employee() { }
      
        public Employee(string name, string dob, Account acc) : base(name, dob)
        {
            this.acc = acc;
        }

        public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        

        public override void display()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Name = {base.Name}");
            Console.WriteLine($"DOB = {base.DOB}");
            acc.displayAccDetails();



        }


    }
}

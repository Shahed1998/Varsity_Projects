using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ========================================================
             * 
             *                   Employee section
             *  
             ==========================================================*/

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            
            Account acc1 = new Account(1, 150.1, "Emp");
            Account acc2 = new Account(2, 200.1, "Emp");
            Account acc3 = new Account(3, 100.1, "Emp");

            // empty constructor.
            emp1.Name = "Wolverine";
            emp1.DOB = "1920";
            emp1.setAcc(acc1);
            emp1.display();

            emp2.Name = "Sabretooth";
            emp2.DOB = "1910";
            emp2.setAcc(acc2);
            emp2.display();

            // parameterized constructor.
            Employee emp3 = new Employee("Juggernaut","1950",acc3);
            emp3.display();

            /* ========================================================
             * 
             *                   Customer section
             *  
             ==========================================================*/
            Customer cus1 = new Customer();
            Account acc4 = new Account(4, 500, "Cus");
            Account acc5 = new Account(5, 50, "Cus");

            // empty constructor.
            cus1.Name = "Professor X";
            cus1.DOB = "1940";
            cus1.setAcc(acc4);
            cus1.display();

            // parameterized constructor.
            Customer cus2 = new Customer("Wade Wilson", "1970", acc5);
            cus2.display();


            Console.ReadKey();
        }
    }
}

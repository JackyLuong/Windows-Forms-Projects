using System;
using System.Collections.Generic;

namespace EmployeeClasses
{
    class Program
    {
        private void programArchive1()
        {
            Employees Bob = new Employees("Bob", 40, 20);
            PermanentEmployee Ann = new PermanentEmployee("Ann", 35, 25.2m, 0.05m);
            decimal pay = Bob.CalcPay();
            Console.WriteLine(Bob); // calls ToString method
            Console.WriteLine(pay.ToString("c"));

            Console.WriteLine(Ann);
            //decimal basePay = Ann.CalcPay();
            decimal deduction = Ann.CalcRRSP();
            pay = Ann.CalcPay();
            //Console.WriteLine("BasePay: " + basePay.ToString("c"));
            Console.WriteLine("Deduction: " + deduction.ToString("c"));
            //Console.WriteLine("Pay With Deduction: " + (basePay - deduction).ToString("c"));
            Console.WriteLine("Pay With Deduction: " + pay.ToString("c"));

            Employees emp = Ann; // can access object of derived class to  ariable of base class
            pay = emp.CalcPay(); // calculate pay from permanentEmployee - polymorphism
                                 // actual type of the object determines which method is called (rather than variable type)
            Console.WriteLine("Pay: " + pay.ToString("c")); // calculate pay from child
            decimal deduction2 = ((PermanentEmployee)emp).CalcRRSP();
            Console.WriteLine(emp);
            Console.WriteLine("Deduction: " + deduction2.ToString("c"));
            Console.WriteLine("Pay With Deduction: " + pay.ToString("c")); // calculate pay from child
        }
        static void Main(string[] args)
        {
            Employees bob = new Employees("Bob", 40, 20);
            PermanentEmployee ann = new PermanentEmployee("Ann", 35, 25.5m, 0.05m);

            List<Employees> payRoll = new List<Employees>(); // empty list
            payRoll.Add(bob);
            payRoll.Add(ann);
            payRoll.Add(new Employees("chris", 25, 27.5m));
            payRoll.Add(new PermanentEmployee("Dana", 25, 27.5m,0.08m));
            decimal pay;
            foreach(Employees employee in payRoll)
            {
                Console.WriteLine(employee);
                if(employee is PermanentEmployee)
                {
                    PermanentEmployee permEmployee = (PermanentEmployee)employee; // type cast to execute certain methods that only pertain in the child class
                    Console.WriteLine(permEmployee.CalcRRSP().ToString("c"));
                }
                pay = employee.CalcPay(); // Calls apporiate version - POLYMORPHISM: Automatically called the object based on the acutal object's type
                                          // instead of its variable type
                Console.WriteLine(pay);
            }
        }
    }
}

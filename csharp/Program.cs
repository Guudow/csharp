using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("**** Fun with static data ****/n");
            SavingsAccount s1 = new SavingsAccount(50);
            
            // print the current interest rate 
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            
            // try to change the interest rate 
            SavingsAccount.SetInterestRate(0.08);
            
            // make a second account 
            SavingsAccount s2 = new SavingsAccount(100);
            
            // should print 0.08..
            
            // Make new object, this does not reset the interest rate
            // SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest| Rate is: {0}", SavingsAccount.GetInterestRate());
            // // make a motorcycle with a rider named Tiny 
            // Motorcycle c = new Motorcycle(5);
            // c.SetDriverName("Tiny");
            // c.PopAwheely();
            // Console.WriteLine("Rider name is {0}", c.drivename); // prints an empty name value 
            // Console.WriteLine("***** Fun with Class Type *****\n");
            //
            // // invoking the default constructor
            // Car Chuck = new Car();
            // Chuck.PrintState();
            //
            // Car myCar = new Car();
            // myCar.petName = "Henry";
            // myCar.currentSpeed = 10;
            //
            // // Speed up the car a few times and print out the 
            // // new state 
            // for (int i = 0; i <= 10; i++)
            // {
            //     myCar.SpeedUp(5);
            //     myCar.PrintState();
            //     
            // }

            Console.ReadLine();
        }
    }
}
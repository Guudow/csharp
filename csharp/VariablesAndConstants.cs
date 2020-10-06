using System;

namespace csharp
{
    public class VariablesandConstants
    {
        static void main(string[] args)
        {
            byte number = 5;
            int count = 10;
            float totalPrce = 20.95f;
            char character = 'A';
            string firstName = "Mohamed";
            bool isWorking = false;
            
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrce);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);



        }


    }
}
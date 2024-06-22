using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Printing output

            // datatypes 
            // Model : Car
            int width;
            double weight;
            char fuel;
            string ownerName;
            bool isAutoGear;
            width = 55;
            weight = 40.5;
            fuel = 'P';
            ownerName = "Hyderabad IT employee";
            isAutoGear = true;
            Console.WriteLine("Hello World!");
            Console.WriteLine("width is "+ width);
            Console.WriteLine("weight is " + + weight);
            Console.WriteLine("fuel is " + fuel); // P petrol, D diesel
            Console.WriteLine("ownerName is " + ownerName);
            Console.WriteLine("isAutoGear " + isAutoGear);

            // 2. Accepting user input

            Console.WriteLine("Enter any price");
            int newNumber = 0;
            int.TryParse(Console.ReadLine(), out newNumber);
            Console.WriteLine("price entered is " + newNumber);

            // 3. Conditional statement : If ElseIf, AND, Or, Conditional

            int budget = 50;
            bool readyForRisk = false;

            Console.WriteLine("Want to take if slight higher - anwer either true/false?");
            bool.TryParse(Console.ReadLine(), out readyForRisk);
            if (newNumber < budget)
            {
                Console.WriteLine("We can go ahead with sale!!");
            }
            else if (newNumber < budget + 5 && readyForRisk)
            {
                Console.WriteLine("Have to manage, lets take the risk!!");
            }
            else if(newNumber < budget + 5)
            {
                Console.WriteLine("Can we manage? it is risk!!");
            }
            else 
            {
                Console.WriteLine("Wait for a year more!!");
            }

            // 4. Conditional Looping statement : For





        }
    }
}
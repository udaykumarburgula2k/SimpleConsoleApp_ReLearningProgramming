namespace SimpleConsoleApp
{
    internal class SumOfDigitsForGivenNumber
    {
        public static void CalculateSumOfDigits()
        {
            int provideNumber;
            Console.WriteLine("To know sum of digits, Enter any number");
            int.TryParse(Console.ReadLine(), out provideNumber);

            int quotient = 0, reminder = 0, sum = 0, newprovideNumber=0;
            newprovideNumber = provideNumber;

            while (newprovideNumber != 0 ) 
            {
                quotient = newprovideNumber / 10;
                reminder = newprovideNumber % 10;
                newprovideNumber = quotient;
                sum = sum + reminder;
            }

            Console.WriteLine("Sum of digits in "+ provideNumber +" number is "+ sum);

            /*
             365 : Sum of 3,6,5
             
             Iteration#1
             365/10 
             quotient : 36
             reminder : 5 
            
             Iteration#2
             Take quotient 36 
             36/10 
             quotient : 3
             reminder : 6 

             Iteration#3
             3/10 
             quotient : 0
             reminder : 3 

            */
        }
    }
}

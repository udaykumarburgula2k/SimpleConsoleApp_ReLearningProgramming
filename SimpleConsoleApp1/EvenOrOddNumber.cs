namespace SimpleConsoleApp
{
    internal class EvenOrOddNumber
    {
        public static void DecideEvenOrOddNumber()
        {
            int provideNumber;
            Console.WriteLine("To know even or odd, Enter any number");
            int.TryParse(Console.ReadLine(), out provideNumber);

            CheckEvenOdd(provideNumber);
        }

        private static void CheckEvenOdd(int provideNumber)
        {
            if (provideNumber % 2 == 0)
            {
                Console.WriteLine(provideNumber + " is a even number");
            }
            else
            {
                Console.WriteLine(provideNumber + " is a even number");
            }
        }
    }
}

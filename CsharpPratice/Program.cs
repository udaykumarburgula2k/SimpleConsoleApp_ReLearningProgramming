using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace CsharpPratice
{

    /// <summary>
    /// questpond learning
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="input"></param>

        /*
        * 1. Do not hit around the bush
        * 2. Say the important points first
        * 3. Use polished right technical vocabulary
        * 
        */

       

        static void Main(string[] args)
        {



            #region delegate and events
            /*
             Delegate - is a type that defines a method signature
             Delegates are callbacks which helps to communicate between 
                concurrent, async and parallel processing
             */


            MyFileSearch x = new MyFileSearch();
            x.SendData = Reciever; // subscribing to the event
            //somePointer = x.SearchFile;
            //somePointer("c:\\temp\\test.txt");


            Task.Run(() => x.SearchFile("c:\\temp\\test.txt")); // non-blocking call.
            x.SearchFile("c:\\temp\\test.txt"); // blocking call.

            Console.WriteLine("Delegate!!");
            Console.ReadLine();

            #endregion delegate and events


            #region out parameter 
            /* multiple out parameters */
            //int add = 0, sub = 0;
            //MyMath(10, 10, out add, out sub);
            //Console.WriteLine("out parameter !!" + "--" + add +"--"+ sub);

            #endregion out parameter 


            #region using Task 

            /*Task parallel library: does parallel processing 
             2 processor - will use processor use parallel processing, task can result, cancel, use async await
            wrapper over threading
            3Ps
            1) Pooling Threads
            2) Parallel Processing
            3) Plus [return, result, cancel, chain, async await]

            .NET CORE <-- TPL used.
            .NET core 2 old code <- thread may used.
             */

            //try
            //{
            //    Task t = new(Method1);
            //    t.Start();

            //    Task t2 = new(Method2);
            //    t2.Start();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("exception", ex);
            //}
            //finally 
            //{
            //    Console.WriteLine("finally!!");
            //}



            #endregion using Task 


            #region using Thread
            /* Thread - run parallel execution of method 
                2 processor - will not use, have cpu affinity, uses context switching, timeslicing
             */

            //Thread t = new Thread(Method1);
            //t.Start();

            //Thread t2 = new Thread(Method2);
            //t2.Start();

            #endregion using Thread

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        static void Reciever(string filename)
        {
            Console.WriteLine("Reciever called with filename: " + filename);
        }

        static void MyMath(int num1, int num2, out int add, out int sub)
        {
            add = num1 + num2;
            sub = num1 - num2;
        }

        static void Method1()
        {
            // for loop 1000 and print 1 to 1000
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(500); // Simulating some work
                Console.WriteLine("Method1..");
            }
            //Thread.Sleep(1000);
            Console.WriteLine("Method1 completed.");
        }
        static void Method2()
        {
            // for loop 1000 and print 1 to 1000
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(500); // Simulating some work
                Console.WriteLine("Method2..");
            }
            //Thread.Sleep(1000);
            Console.WriteLine("Method2 completed.");
        }
    }

    public class MyFileSearch
    {
        // 1. Define the delegate
        public delegate void searchMethod(string input);
        public static searchMethod SendData = null;


        public void SearchFile(string fileName)
        {
            // Simulating file search
            Console.WriteLine($"Searching for file: {fileName}");
            Thread.Sleep(10); // Simulating some delay
            Console.WriteLine($"File {fileName} found!");
            SendData(string.IsNullOrEmpty(fileName) ? "No file found" : fileName);
        }
    }
}

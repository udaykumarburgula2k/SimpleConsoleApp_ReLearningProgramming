using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class UsingArrayList
    {
        public static ArrayList BasicOperationOnArrayList()
        {
            ArrayList resultList = new ArrayList();
            resultList.Add(90);
            resultList.Add(95);

            ArrayList personList = new ArrayList();
            personList.Add("Moses");
            personList.Add("Mandela");
            personList.Add("Job");
            personList.Add("Kapil");
            personList.Add("Teresa");
            personList.Add("Praveen");
            personList.Add("Sandeep");
            personList.Add("Raju");
            personList.Add("Uday");
            personList.Add("Krishna");
            personList.Add("Sudheer");
            personList.Add("Dhoni");
            personList.Add("Samar");
            // Add List
            foreach (var item in personList)
            {
                string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(arrayItem);
            }
            // Modify List
            personList.Insert(1, "John");
            Console.WriteLine("=====Modify List======" + "added John");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            //remove first item from person list using index
            personList.Remove("Samar");
            Console.WriteLine("=====Modified List======" + "removed Samar");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            //remove first item from person list using index
            personList.RemoveAt(0);
            Console.WriteLine("remove first item from person list");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            //remove first two item from person list using index
            personList.RemoveRange(0, 2);
            Console.WriteLine("remove first two item from person list");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            //Remove all items from person list
            Console.WriteLine("Remove all items from person list");
            int totalItems = personList.Count;
            Console.WriteLine(string.Format($"Total Number Of Items in ArrayList: {totalItems}"));
            personList.Clear();
            totalItems = personList.Count;
            Console.WriteLine(string.Format($"Total Number Of Items in ArrayList: {totalItems}"));
            return resultList;
        }


        /// <summary>
        /// BasicSearchOperationOnArrayList
        /// ex #1 i/p   arr[] = { 20, 5 , 7 , 25}  search item x = 5   O/p : 1 (index of 5)
        /// ex #2  x =15 o/p : -1 (when element not found)
        /// 
        /// Time complexity TC : O(n) 
        /// Space Complexity SC : constant
        /// </summary>
        /// <param name="givenSearchNameValue"></param>
        /// <returns></returns>
        public static ArrayList BasicSearchOperationOnArrayList(string givenSearchNameValue)
        {
            ArrayList personList = new ArrayList();
            personList.Add("Moses");
            personList.Add("Mandela");
            personList.Add("Job");
            personList.Add("Kapil");
            personList.Add("Teresa");
            personList.Add("Praveen");
            personList.Add("Sandeep");
            personList.Add("Uday");
            personList.Add("Krishna");
            personList.Add("Sudheer");
            personList.Add("Dhoni");
            personList.Add("Raju");
            personList.Add("Samar");

            int indexOfName = 0;
            bool notFound = true;
            foreach (var item in personList)
            {
                if (givenSearchNameValue != null && item != null)
                {
                    if (item.ToString() == givenSearchNameValue)
                    {
                        notFound = false;
                        Console.WriteLine("givenSearchNameValue:" + givenSearchNameValue + " IS AT INDEX" + indexOfName);
                    }
                    indexOfName++;
                }
                if ((personList.Count - 1) == indexOfName && notFound) 
                {
                    Console.WriteLine("Given Name '"+ givenSearchNameValue +"' not found!!");
                }
            }
            return personList;
        }


        /// <summary>
        /// BasicSearchOperationOnIntArrayList         
        /// - TC : O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int BasicSearchOperationOnIntArrayList(int[] arr, int n, int x) 
        {
            Console.WriteLine("BasicSearchOperationOnIntArrayList");
            Console.WriteLine("array elements length"+ arr.Length);
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("element"+ j +"-"+ arr[j]);
            }

            for (int i = 0; i < n; i++) 
            {
                if (arr[i] == x)
                {
                    Console.WriteLine("");
                    return i;
                }
            }
            return -1;
        }

    }
}

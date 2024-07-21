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
        /// <summary>
        /// Usageof Array
        /// OperationsOnArray5.png
        /// </summary>
        /// <returns></returns>
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
            personList.Add("Sandy");
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
            personList.Remove("Sandy");
            Console.WriteLine("=====Modified List======" + "removed Sandy");
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
            personList.Add("Sandy");

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
                    Console.WriteLine("Given Name '" + givenSearchNameValue + "' not found!!");
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
            Console.WriteLine("array elements length" + arr.Length);
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("element" + j + "-" + arr[j]);
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


        /// <summary>
        /// BasicInsertArrayItemInList
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lengthOfArray"></param>
        /// <param name="insertElement"></param>
        /// <param name="insertPosition"></param>
        /// <returns></returns>
        public static int BasicInsertArrayItemInList(int[] arr, int lengthOfArray,
            int insertElement, int insertPosition)
        {
            /// Insert Array item in array at position
            /// i/p : arr[] = {5,7,10,20}
            /// x= 3
            /// position = 2
            /// o/p : {5,3**,7,10,20}  -- move 20 to n+1 position and 10 n position
            /// -----------------------------------------
            /// TC: O(n), insert as first(worst case) or last (best case) element

            Console.WriteLine("BasicInsertArrayItemInList");
            Console.WriteLine("arr.IsFixedSize" + arr.IsFixedSize);
            int idx = insertPosition - 1; // index position to be inserted
            if (lengthOfArray < insertPosition)
            {
                Console.WriteLine("Cannot insert in an fixed size array beyond its size!!");
                return lengthOfArray; // if array is full we cannot add an element to fixed array.
            }
            for (int i = lengthOfArray - 2; i >= idx; i--) // index start from 0 to 4
            {
                arr[i + 1] = arr[i];
            }
            arr[idx] = insertElement;
            Console.WriteLine("array elements length" + arr.Length);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("element" + j + "-" + arr[j]);
            }
            return insertElement;
        }

        /// <summary>
        /// delete GivenItem Operation On Array
        /// TC: O(n) 
        /// </summary>
        /// <param name="givenArray"></param>
        /// <param name="deleteItem"></param>
        /// <returns></returns>
        public static int deleteGivenItemOperationOnArray(int[] givenArray, int deleteItem)
        {
            bool found = false;
            int INDEX = 0;

            for (int i = 0; i <= givenArray.Length - 1; i++)
            {
                if (givenArray[i] == deleteItem)
                {
                    found = true;
                    Console.WriteLine("delete item '" + deleteItem + "' found at index#" + i + ".");
                    INDEX = i;
                    // break;
                }
                if (INDEX > 0 && found)
                {
                    if (i != givenArray.Length - 1)
                    {
                        givenArray[i] = givenArray[i + 1];
                    }
                    else
                    {
                        givenArray[i] = 0;
                    }
                }
            }
            if (!found)
            {
                INDEX = -1;
                Console.WriteLine("delete item not " + deleteItem);
            }
            Console.WriteLine("result array elements");
            for (int j = 0; j < givenArray.Length; j++)
            {
                Console.WriteLine("element" + j + "-" + givenArray[j]);
            }
            return INDEX;
        }


    }
}

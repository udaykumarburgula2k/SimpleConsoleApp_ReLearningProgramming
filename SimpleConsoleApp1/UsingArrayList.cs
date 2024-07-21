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


        /// <summary>
        /// largestElementOfAnArray
        /// TC: O(n)
        /// </summary>
        /// <param name="givenArray"></param>
        /// <param name="searchElement"></param>
        /// <returns></returns>
        public static int largestElementOfAnArray(int[] givenArray)
        {
            Console.WriteLine("largestElementOfAnArray");
            // expected Output = 2;// index of 20  <-- array { 10, 5, 20, 8 };
            int INDEX = -1;
            int largest = 0;
            if(givenArray.Length <= 0) return INDEX;
            largest = givenArray[0];
            for (int i = 1; i <= givenArray.Length - 1; i++)
            {
                if (givenArray[i] > largest) 
                {
                    largest = givenArray[i];
                    INDEX = i;
                }
            }
            return INDEX;
        }


        /// <summary>
        /// largestElementOfAnArray_better2
        /// TC: O(n)
        /// </summary>
        /// <param name="givenArray"></param>
        /// <param name="searchElement"></param>
        /// <returns></returns>
        public static int largestElementOfAnArray_better2(int[] givenArray)
        {
            Console.WriteLine("largestElementOfAnArray_better2");
            // expected Output = 2;// index of 20  <-- array { 10, 5, 20, 8 };
             int result = 0;
            if (givenArray.Length <= 0) return -1;
            if (givenArray.Length == 1) return 0;

            for (int i = 1; i <= givenArray.Length - 1; i++)
            {
                if (givenArray[i] > givenArray[result])
                {
                    result = i;
                }
            }
            return result;
        }

        public static int secondElementOfAnArray_linear(int[] givenArray, int highest =2)
        {
            Console.WriteLine("secondElementOfAnArray");
            // ex1: array { 10, 5, 8, 20 };  2nd largest number is 10 index = 0 is expected output.
            // ex2: array { 20, 10, 20, 8, 12 }; expected output 4 index of 12
            // ex3: array { 10,10,10} expected output -1 as there is no 2nd largest element
            int result = -1, largest = 0;

            /*
             Given array { 10, 5, 8, 20 }
             step 1: 10, 5, 8 
             step 2: sort 10 largest, 8 2nd, 5 3rd
             step 3: take 20 new element compare with largest, 2nd and 3rd.
             */

            for (int i = 1; i <= givenArray.Length - 1; i++)
            {
                if (givenArray[i] > givenArray[largest])
                {
                    result = largest;
                    largest = i;
                }
                else if (givenArray[i] == givenArray[largest]) { 
                    // ignore
                }
                else if (givenArray[i] != givenArray[largest])
                {
                    if (result == -1 || givenArray[i] > givenArray[result]) 
                    {
                        result = i;
                    }
                }

            }
            return -1;
        }


    }
}

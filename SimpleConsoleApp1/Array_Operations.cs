using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleConsoleApp
{

    /// <summary>
    /// Array_Operations
    /// </summary>
    internal class Array_Operations
    {
        /// <summary>
        /// Two Sum : https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Dictionary<int, int> TwoSum(int[] nums, int target)
        {
            
            /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
            /// You can return the answer in any order.
            /// Example 1:
            /// Input: nums = [2,7,11,15], target = 9
            /// Output: [0, 1]
            /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            /// Hint 1: A really brute force way would be to search for all possible pairs of numbers but that would be too slow.Again, it's best to try out brute force solutions for just for completeness. It is from these brute force solutions that you can come up with optimizations.
            /// Hint 2 So, if we fix one of the numbers, say x, we have to scan the entire array to find the next number y which is value - x where value is the input parameter.Can we change our array somehow so that this search becomes faster?
            /// Hint 3 The second train of thought is, without changing the array, can we use additional space somehow? Like maybe a hash map to speed up the search?
            
            // Example 1:
            // Input: nums = [2,7,11,15], target = 9
            int startIndex = 0, loopIndex=0, endIndex = nums.Length;
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            while (startIndex < endIndex) {
                for (loopIndex = startIndex+1; loopIndex < endIndex-1; loopIndex++)
                {
                    if (nums[startIndex] + nums[loopIndex] == target)
                    {
                        numIndices.Add(startIndex , loopIndex);
                    }
                }
                startIndex++;
            }

            foreach (var i in numIndices) { 
                Console.WriteLine(i.Key.ToString() + ","+ i.Value.ToString());   
            }

            return numIndices;
        }
    }
}

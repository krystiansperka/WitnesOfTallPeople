
using System;
using System.Collections;
using System.Collections.Generic;

/*There are n people lined up, and each have a height represented as an integer. A murder has happened right in front of them, and only people who are taller than everyone in front of them are able to see what has happened. How many witnesses are there?

Example:
Input: [3, 6, 3, 4, 1]  
Output: 3
Explanation: Only [6, 4, 1] were able to see in front of them.
 #
 #
 # #
####
####
#####
36341                                 x (murder scene)
Here's your starting point:

def witnesses(heights):
  # Fill this in.

print witnesses([3, 6, 3, 4, 1])
# 3
*/

namespace WitnesOfTallPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var solution = new Solution();
            solution.RunTest1();
        }
    }

    public class Solution
    {
        public int RunTest1()
        {
            int[] testArray = { 3, 6, 3, 4, 1 };
            return Witnesses(testArray);
        }

        public int Witnesses(int[] inputArray)
        {
            int result = 0;
            int[] peopleBeforeWitness = new int[inputArray.Length];

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                if (i < inputArray.Length - 1)
                {
                    bool someoneHigher = false;

                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        if (inputArray[j] > inputArray[i])
                        {
                            someoneHigher = true;
                            break;
                        }


                    }

                    if (someoneHigher == false)
                        result++;
                }
                else
                {
                    result++;
                }
            }

            return result;
        }
    }
}

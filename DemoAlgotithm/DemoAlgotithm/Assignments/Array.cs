﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgotithm.Assignments
{
    public partial class Assignments
    {
        #region
        /*
         * Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.

        Example

        For sequence = [1, 3, 2, 1], the output should be
        almostIncreasingSequence(sequence) = false;

        There is no one element in this array that can be removed in order to get a strictly increasing sequence.

        For sequence = [1, 3, 2], the output should be
        almostIncreasingSequence(sequence) = true.

        You can remove 3 from the array to get the strictly increasing sequence [1, 2]. Alternately, you can remove 2 to get the strictly increasing sequence [1, 3].
         */
        #endregion
        public static bool AlmostIncreasingSequence(int[] sequence)
        {
            //TODO:
            var length = sequence.Length;

            if (length < 3)
            {
                return (sequence[0] < sequence[1]);
            }

            for (int i = 1; i < length - 1; i++)
            {
                if (sequence[i - 1] < sequence[i + 1])
                {
                    
                }
            }
            return false;
        }

        #region
        //Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size.Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. He may need some additional statues to be able to accomplish that.Help him figure out the minimum number of additional statues needed.

        //Example

        //For statues = [6, 2, 3, 8], the output should be
        //makeArrayConsecutive2(statues) = 3.

        //Ratiorg needs statues of sizes 4, 5 and 7.

        //Input/Output

        //[time limit] 6000ms(cs)
        //[input]
        //        array.integer statues

        //An array of distinct non-negative integers.

        //Guaranteed constraints:
        //1 ≤ statues.length ≤ 10,
        //0 ≤ statues[i] ≤ 20.

        //[output] integer

        //The minimal number of statues that need to be added to existing statues such that it contains every integer size from an interval [L, R] (for some L, R) and no other sizes.
        #endregion
        public static int MakeArrayConsecutive2(int[] statues)
        {
            if (statues.Length < 2) return 0;

            Array.Sort(statues);

            int vResult =0;

            for (int i = 0; i < statues.Length - 1; i++)
            {
                vResult += statues[i + 1] - statues[i] - 1;
            }

            return vResult;
        }

        public static int AdjacentElementsProduct(int[] inputArray)
        {
            if (inputArray.Length == 2)
            {
                return inputArray[0] * inputArray[1];
            }

            var length = inputArray.Length;
            int result = int.MinValue;

            for (int i = 0; i < length - 1; i += 1)
            {
                int val = inputArray[i] * inputArray[i + 1];
                if (result < val)
                {
                    result = val;
                }
            }

            return result;
        }

    }
}

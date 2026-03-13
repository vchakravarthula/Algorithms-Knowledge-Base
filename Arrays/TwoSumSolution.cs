using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms_Knowledge_Base.Arrays
{
    /// <summary>
    /// Problem: Two Sum (LeetCode #1)
    /// Difficulty: Easy
    /// Concepts: Hash Table, Array
    /// </summary>
    public class TwoSumSolution
    {
        /* * TIME COMPLEXITY: O(n) - We traverse the list containing n elements only once.
         * SPACE COMPLEXITY: O(n) - The extra space required depends on the number of items stored in the hash table.
         * * STRATEGY: 
         * Instead of a nested loop (O(n^2)), we use a Dictionary to store the 'complement' 
         * of each number as we iterate. This trades space for speed.
         */
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }

    // --- UNIT TESTS ---
    // Including tests proves you verify your edge cases (Negative numbers, Empty arrays, etc.)
    public class TwoSumTests
    {
        [Fact]
        public void StandardCase_ReturnsCorrectIndices()
        {
            var sol = new TwoSumSolution();
            var result = sol.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.AreEqual(new int[] {0,1}, result);
        }
    }
}

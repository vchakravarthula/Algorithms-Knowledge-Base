namespace Algorithms.SlidingWindow;

public class MinimumSizeSubarraySum {
    /* * PROBLEM: LeetCode #209
     * TIME: O(n) - Amortized (each element visited twice)
     * SPACE: O(1) - No extra data structures used
     */
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int currentSum = 0;
        int minLength = int.MaxValue;

      for(int right = 0; right< nums.Length;right++)
      {
        // 1. EXPAND: Add the current number to the window sum
        currentSum += nums[right];

        // 2. SHRINK: While the window meets the target, try to make it smaller
        while(currentSum >= target)
        {
          // Update the result inside the while loop for "Shortest" problems
          minLength = Math.Min(minLength, right - left + 1);

          // Subtract the left element and move the pointer
          currentSum = currentSum - nums[left];
          left++;
        }
      }

      // Return 0 if no such subarray was found
      return minLength = int.MaxValue ? 0 : minLength;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Knowledge_Base.SlidingWindow
{
    public class LongestSubstring
    {
        /* * PROBLEM: LeetCode #3
         * TIME: O(n) - Each char is visited at most twice (by left and right).
         * SPACE: O(min(m, n)) - Size of the charset in the map.
         */
        public int LengthOfLongestSubstring(string s)
        {
            // We use a sliding window approach with two pointers (left and right) to track the current substring.
            // A HashSet is used to store unique characters in the current window.
            // We expand the right pointer to include new characters until we encounter a duplicate.
            // When a duplicate is found, we move the left pointer to shrink the window until the duplicate is removed.
            // This way, we ensure that the substring between left and right always contains unique characters, and we keep track of the maximum length found.
            // This approach efficiently finds the longest substring without repeating characters in a single pass through the string.
            // Example: For "abcabcbb", the longest substring without repeating characters is "abc" with length 3.
            int res = 0, left = 0, right = 0;

            var set = new HashSet<char>();

            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    res = Math.Max(res, right - left + 1);
                    right++;
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }

            }
            return res;
        }
    }
}

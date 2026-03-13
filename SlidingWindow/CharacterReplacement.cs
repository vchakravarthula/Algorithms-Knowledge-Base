using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Knowledge_Base.SlidingWindow
{
    /* * PROBLEM: LeetCode #424
     * TIME COMPLEXITY: O(n) - Single pass through the string.
     * SPACE COMPLEXITY: O(1) - Fixed size array of 26 for English uppercase letters.
     * * STRATEGY: 
     * We maintain a window and track the frequency of characters. 
     * 'maxFreq' is the count of the most frequent character seen in the current window.
     * If (window size - maxFreq) > k, we have more than k characters to replace, 
     * so we must shrink the window from the left.
     */
    public class CharacterReplacement
    {
        public int CharacterReplacementMethod(string s, int k)
        {
            // We use a sliding window approach with two pointers (left and right) to track the current substring.
            // An array of size 26 is used to count the frequency of each uppercase letter in the current window.            
            // For instance, if the current window is "AABABBA" and k=1, we can replace one 'B' with 'A' to get "AAAAABA", which has a length of 4.
            int maxFreq = 0, left = 0, maxLength = 0;
            var count = new int[26];

            for(int right = 0; right < s.Length; right++)
            {
                maxFreq = Math.Max(maxFreq, ++count[s[right] - 'A']);

                while( (right - left + 1) - maxFreq  > k)
                {
                    count[s[left++] - 'A']--;
                    
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            

            return maxLength;

        }

    }
}

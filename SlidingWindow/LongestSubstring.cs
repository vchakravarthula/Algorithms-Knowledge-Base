using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Knowledge_Base.SlidingWindow
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int res = 0, left = 0, right = 0 ;

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

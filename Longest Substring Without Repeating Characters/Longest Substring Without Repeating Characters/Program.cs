using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        public int LengthOfLongestSubstring(string s)
        {

            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left)
                {
                    // Update the left pointer to the index after the last occurrence of the repeating character
                    left = charIndexMap[s[right]] + 1;
                }

                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);

                foreach (var entry in charIndexMap)
                {
                    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                }
                Console.WriteLine();
            }

            return maxLength;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int x = program.LengthOfLongestSubstring("abcabcbb");
            System.Console.WriteLine(x);
        }
    }
}

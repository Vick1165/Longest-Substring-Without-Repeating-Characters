using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        //Longest Substring Without Repeating Characters
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/
        static void Main(string[] args)
        {
            var input = "abcabcbb";
            var output = LengthOfLongestSubstring(input);
            Console.WriteLine(output);

        }

        public static int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<int>();
            var sum = 0;
            int a_pointer = 0, b_pointer = 0;

            var str = s.ToCharArray();

            while (b_pointer < str.Length)
            {
                if (!set.Contains(str[b_pointer]))
                {
                    set.Add(str[b_pointer]);
                    b_pointer++;
                    sum = Math.Max(set.Count, sum);
                }
                else
                {
                    set.Remove(str[a_pointer]);
                    a_pointer++;
                }
            }


            return sum;
        }

    }
}

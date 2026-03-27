using System;

namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

public class LongestSubstringWithoutRepeating
{
    public static int Solve(string input)
    {
        var left = 0;
        var longest = 0;
        var currentLong = 0;
        var charHash = new HashSet<char>();

        for (var right = 0; right < input.Length; right++)
        {
            var current = input[right];
            var added = charHash.Add(current);

            if (!added)
            {// Repeated 
                currentLong = right - left;
                charHash.Remove(current);
                longest = Math.Max(currentLong, longest);
                // Move left  
                left++;
            }
        }
        longest = Math.Max(currentLong, longest);
        return longest;
    }
}

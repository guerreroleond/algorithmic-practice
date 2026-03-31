using System;

namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

public class LongestSubstringWithoutRepeating
{
    public static int Solve(string input)
    {
        var left = 0;
        var longest = 0;
        var currentLong = 0;
        var charDict = new Dictionary<char, int>();

        for (var right = 0; right < input.Length; right++)
        {
            var current = input[right];

            if (charDict.TryGetValue(current, out int lastRepeatedIndex)
            && lastRepeatedIndex >= left)
            {// Repeated.               
                left = lastRepeatedIndex + 1; 
            }

            charDict[current] = right;
            currentLong = (right - left) + 1;
            longest = Math.Max(currentLong, longest);
        }
        return longest;
    }
}

// - We need to slide the window to the right until we find a repeated character.
//     - We add the current characters to a dictionary so we can keep track of characters 
//       and the repeated index.
//     - Increase the window
// - When repeated:
//     - Shrink the window to the right (move the left pointer to where the repeated 
//       existing character index).
//     - Calculate the current window
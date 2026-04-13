using System;

namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

/// <summary>
/// [AP001] ** Sliding Window 
/// Given a string `s`, find the length of the **longest** **substring** without duplicate characters.
/// **Example 1:**
/// Input: s = "abcabcbb"
/// Output: 3
/// Explanation: The answer is "abc", with the length of 3. 
/// Note that "bca" and "cab" are also correct answers.
/// </summary>
public class LongestSubstringWithoutRepeating
{
    /// <summary>
    /// Slide the window to the right, store current char so we can check if repeated later,
    /// if repeated, shrink left until valid again (lastRepeated + 1),
    /// calculate current window size, update longest.
    /// </summary>
    /// <param name="input">Input string to evaluate.</param>
    /// <returns>Longest Substring length Without Repeating chars.</returns>
    public static int Solve(string input)
    {
        var left = 0;
        var longest = 0;
        var charDict = new Dictionary<char, int>();

        // Expand window to the right.
        for (var right = 0; right < input.Length; right++)
        {
            var current = input[right];

            if (charDict.TryGetValue(current, out int lastRepeatedIndex)
            && lastRepeatedIndex >= left)
            {// Shrink left when Repeated until valid again.               
                left = lastRepeatedIndex + 1;
            }

            charDict[current] = right;
            var windowSize = (right - left) + 1;
            // Update longest.
            longest = Math.Max(windowSize, longest);
        }
        return longest;
    }
}

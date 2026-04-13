using System.Text;

namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

/// <summary>
/// [AP003] ** Sliding Window **
/// You are given a string `s` and an integer `k`. 
/// You can choose any character of the string 
/// and change it to any other uppercase English character. 
/// You can perform this operation at most `k` times.
/// Return *the length of the longest substring containing the same letter 
/// you can get after performing the above operations*.
/// </summary>
public class LongestRepeatingCharacterReplacement
{
    public static string SolveStringCleanedUp(string s, int allowedChanges)
    {
        int left = 0;
        int maxLength = 0;
        int bestStart = 0;

        var dict = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            dict[c] = dict.GetValueOrDefault(c) + 1;
            int maxFreq = dict.Values.Max();

            while ((right - left + 1) - maxFreq > allowedChanges)
            {
                dict[s[left]]--;
                left++;
                maxFreq = dict.Values.Max();
            }

            int windowSize = right - left + 1;

            if (windowSize > maxLength)
            {
                maxLength = windowSize;
                bestStart = left;
            }
        }

        return s.Substring(bestStart, maxLength);
    }


    public static string SolveString(string s, int allowedChanges)
    {
        var left = 0;
        // Max Frequency of all present chars (not historical, it can be reduced).
        var maxFreq = 0;
        var charDict = new Dictionary<char, int>();
        var currentS = new StringBuilder();
        var longestS = new StringBuilder();

        for (var right = 0; right < s.Length; right++)
        {
            // Expand.
            var current = s[right];
            charDict[current] = charDict.GetValueOrDefault(current) + 1;
            currentS.Append(current);
            maxFreq = charDict.Values.Max();

            var windowSize = right - left + 1;
            var badChars = windowSize - maxFreq;
            // Shrink if invalid.
            while (badChars > allowedChanges)
            {
                charDict[s[left]]--;
                left++;
                currentS.Remove(0, 1);
                windowSize = right - left + 1;
                maxFreq = charDict.Values.Max();
                badChars = windowSize - maxFreq;
            }
            // Update when bigger.
            if (currentS.Length > longestS.Length)
                longestS = new StringBuilder(currentS.ToString());
        }

        return longestS.ToString();
    }

    /// <summary>
    /// Slide the window to the right, increment current char count,
    /// keep track of max frequency of chars inside current valid window,
    /// valid window is when bad chars (window size - max freq) <= allowed changes.
    /// If invalid window, shrink left until valid again.
    /// calculate current window size, update max lenght.
    /// </summary>
    /// <param name="inputString">Input string to evaluate.</param>
    /// <param name="allowedChanges">Allowed quantity of chars to replace.</param>
    /// <returns>
    /// The length of the longest substring containing the same letter + allowed changes. 
    /// </returns>
    public static int Solve(string inputString, int allowedChanges)
    {
        var left = 0;
        var maxLength = 0;
        var maxFreq = 0;
        var charDict = new Dictionary<char, int>();

        for (var right = 0; right < inputString.Length; right++)
        {
            // Expand window to the right.
            var current = inputString[right];
            charDict[current] = charDict.GetValueOrDefault(current) + 1;

            maxFreq = Math.Max(maxFreq, charDict[current]);

            var windowSize = right - left + 1;
            var badChars = windowSize - maxFreq;
            // Shrink left when Repeated until valid again. 
            while (badChars > allowedChanges)
            {
                charDict[inputString[left]]--;
                left++;
                windowSize = right - left + 1;
                badChars = windowSize - maxFreq;
            }

            // Update result;
            maxLength = Math.Max(maxLength, windowSize);
        }

        return maxLength;
    }

    public static int SolveShort(string inputString, int allowedChanges)
    {
        var left = 0;
        var maxLength = 0;
        var maxFreq = 0;
        var charDict = new Dictionary<char, int>();

        for (var right = 0; right < inputString.Length; right++)
        {
            // Expand.
            var current = inputString[right];
            charDict[current] = charDict.GetValueOrDefault(current) + 1;

            maxFreq = Math.Max(maxFreq, charDict[current]);

            while ((right - left + 1) - maxFreq > allowedChanges)
            {
                charDict[inputString[left]]--;
                left++;
            }

            // Update result;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

    public static int Wrong(string input, int k)
    {
        var windowSize = input.Length;
        var maxFrec = 0;
        var badChars = 0;
        var charDict = new Dictionary<char, int>();

        for (var i = 0; i < input.Length; i++)
        {
            var current = input[i];
            charDict.TryGetValue(current, out int charCount);
            charDict[current] = charCount + 1;
        }

        var charIndex = 0;
        while (windowSize > k)
        {
            maxFrec = charDict.Values.Max();
            badChars = windowSize - maxFrec;
            var current = input[charIndex];

            var isWindowValid = badChars <= k;
            if (isWindowValid)
            {
                return windowSize;
            }
            else
            {
                charDict.TryGetValue(current, out int charCount);
                if (charCount > 0)
                    charDict[current]--;
                windowSize--;
            }

            charIndex++;
        }

        return 0;
    }
}
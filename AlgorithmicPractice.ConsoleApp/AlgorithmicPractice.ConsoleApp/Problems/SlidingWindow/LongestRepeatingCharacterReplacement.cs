namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

public class LongestRepeatingCharacterReplacement
{
    public static int Solve(string inputString, int allowedChanges)
    {
        var left = 0;
        var maxLength = 0;
        var maxFreq = 0;
        var charDict = new Dictionary<char, int>();

        for(var right = 0; right < inputString.Length; right++)
        {
            // Expand.
            var current = inputString[right];
            charDict[current] = charDict.GetValueOrDefault(current) + 1;

            maxFreq = Math.Max(maxFreq, charDict[current]);

            var windowSize = right - left + 1;
            var badChars = windowSize - maxFreq;
            // Shrink if invalid.
            while(badChars > allowedChanges)
            {
                charDict[inputString[left]]--;
                left++;
                windowSize = right - left + 1;
                badChars = windowSize - maxFreq;
            }

            // Update result;
            windowSize = right - left + 1;
            maxLength = Math.Max(maxLength, windowSize);
            //maxLength = Math.Max(maxLength, right - left + 1);   
        }

        return maxLength;
    }

    public static int Solve2(string inputString, int allowedChanges)
    {
        var left = 0;
        var maxLength = 0;
        var maxFreq = 0;
        var charDict = new Dictionary<char, int>();

        for(var right = 0; right < inputString.Length; right++)
        {
            // Expand.
            var current = inputString[right];
            charDict[current] = charDict.GetValueOrDefault(current) + 1;

            maxFreq = Math.Max(maxFreq, charDict[current]);

            //var windowSize = right - left + 1;
            //var badChars = windowSize - maxFreq;
            // Shrink if invalid.
            //while(badChars > allowedChanges)
            while((right - left + 1) - maxFreq > allowedChanges)
            {
                charDict[inputString[left]]--;
                left++;
            }

            // Update result;
            //windowSize = right - left + 1;
            //maxLength = Math.Max(maxLength, windowSize);
            maxLength = Math.Max(maxLength, right - left + 1);   
        }

        return maxLength;
    }

    public static int SolveWrong(string input, int k)
    {
        var windowSize = input.Length;
        var maxFrec = 0;
        var badChars = 0;
        var charDict = new Dictionary<char, int>();

        for(var i = 0;i < input.Length; i++)
        {
            var current = input[i];
            charDict.TryGetValue(current, out int charCount); 
            charDict[current] = charCount + 1;
        } 

        var charIndex = 0;
        while(windowSize > k)
        {
            maxFrec = charDict.Values.Max();
            badChars = windowSize - maxFrec;
            var current = input[charIndex];

            var isWindowValid = badChars <= k;
            if(isWindowValid)
            {
                return windowSize;
            }
            else
            {
                charDict.TryGetValue(current, out int charCount);
                if(charCount > 0)
                    charDict[current]--;
                windowSize--;
            }

            charIndex++;
        }

        return 0;
    }
}
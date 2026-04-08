namespace AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

public class ValidPalindrome
{
    public static bool Solve(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Discard non-alphanumerics.
            while (!char.IsLetterOrDigit(s[left])
                && left < right) left++;
            while (!char.IsLetterOrDigit(s[right])
                && left < right) right--;

            if (char.ToLowerInvariant(s[left]) 
             != char.ToLowerInvariant(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}

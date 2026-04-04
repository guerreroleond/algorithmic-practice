namespace AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

/// <summary>
/// **Difficulty:** Easy
/// Pattern: Opposite pointers
/// Prompt:
/// Given a **sorted array**, find two numbers that sum to target.
/// </summary>
public class TwoSumII
{
    public static int[] Solve(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            if (target == (numbers[left] + numbers[right]))
                // Target!
                return [left, right];
            else if ((numbers[left] + numbers[right]) < target)
                // Too small, move left.
                left++;
            else
                // Too big, move right.
                right--;
        }

        return [];
    }
}

namespace AlgorithmicPractice.ConsoleApp.Problems.DataStructures.Lookups;

/// <summary>
/// **Difficulty** Easy
/// Pattern: 
/// Prompt:
/// Given an array of integers **nums** and an integer **target**,
/// return the indexes of the two numbers that add up to the target.
/// Example:
/// Input: nums = [11,15,7,2]
/// Target: 9
/// Output: [2,3]
/// </summary>
public class TwoSum
{
    public static int[] Solve(int[] numbers, int target)
    {
        Dictionary<int, int> seenNums = [];

        for (var i = 0; i < numbers.Length; i++)
        {
            var compliment = target - numbers[i];
            if (seenNums.TryGetValue(compliment, out int value))
            {// Successful case.
                return [value, i];
            }

            // Store current number and its index.
            seenNums.Add(numbers[i], i);
        }

        throw new ArgumentException("No TwoSum solution for this input.");
    }
}
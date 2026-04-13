namespace AlgorithmicPractice.ConsoleApp.Problems.DynamicProgramming;

/// <summary>
/// You are climbing a staircase. It takes `n` steps to reach the top.
/// Each time you can either climb `1` or `2` steps. 
/// In how many distinct ways can you climb to the top?
/// Example: 
/// Input: steps = 3
/// Output: 3
/// Explanation: There are three ways to climb to the top.
/// 1. 1 step + 1 step + 1 step
/// 2. 1 step + 2 steps
/// 3. 2 steps + 1 step
/// Pattern: *Dynamic Pogramming*
/// The relationship follows the *Fibonacci sequence*, because to reach step 'n',
/// you must have come from either step 'n - 1' or step 'n -2'.
/// </summary>
public class ClimbingStairs
{
    /// <summary>
    /// Stores the `first` and `second` (already known ways)
    ///  to reach 1st{1} and 2nd{2} steps.
    /// Iterate from there until `steps` and each step 
    /// calculate current (`third`) and shift `first` and `second` one step.
    /// Repeat.
    /// NOTE: This is the most efficient (in Space: O(1)), Instead of an array, 
    /// it only stores, the two prev values to calculte the current one
    /// <param name="steps">Steps to reach the top.</param>
    /// <returns>In how many distinct ways can you climb to the top.</returns>
    /// </summary>
    public static int SolveIterative(int steps)
    {
        if (steps <= 2) return steps;
        // Ways to reach 1st and 2nd steps.
        int first = 1;
        int second = 2;

        for (int i = 3; i <= steps; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }

        return second;
    }

    /// <summary>
    /// Stores the `first` and `second` (already known ways)
    ///  to reach 1st{1} and 2nd{2} steps.
    /// Iterate from there until `steps` and each step 
    /// calculate current 'ways[i]' by summing prev and second prev.
    /// Repeat.
    /// <param name="steps">Steps to reach the top.</param>
    /// <returns>In how many distinct ways can you climb to the top.</returns>
    /// </summary>
    public static int Solve(int steps)
    {
        if (steps <= 2) return steps;

        var ways = new int[steps + 1];

        ways[1] = 1;
        ways[2] = 2;

        for (var i = 3; i <= steps; i++)
        {
            ways[i] = ways[i - 1] + ways[i - 2];
        }

        return ways[steps];
    }
}

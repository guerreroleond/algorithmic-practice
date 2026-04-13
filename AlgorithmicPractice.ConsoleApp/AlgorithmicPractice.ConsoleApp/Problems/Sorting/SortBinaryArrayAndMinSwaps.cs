namespace AlgorithmicPractice.ConsoleApp.Problems.Sorting;


/// <summary>
/// [AP009] ** Sorting **
/// Given an array of binary digits, 0 and 1, 
/// sort the array so that all zeros are at one end and all ones are at the other. 
/// Which end doesn’t matter. To sort the array, swap any two adjacent elements. 
/// Determine the minimum number of swaps to sort the array.
/// </summary>
public class SortBinaryArrayAndMinSwaps
{
    /// <summary>
    /// Counts the cost of moving each 0 (or 1) to its sorted position, 
    /// by calculating and accumulating
    /// how far each 0 (or 1) is from its target position,
    /// then returns the minimum of both costs.
    /// </summary>
    /// <param name="nums">Binary array containing only 0s and 1s.</param>
    /// <returns>Minimum number of swaps to sort the array.</returns>
    public static int Solve(int[] nums)
    {
        int targetIndex0 = 0;
        int targetIndex1 = 0;
        int swaps0 = 0;
        int swaps1 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {// How far is for its target position.
                swaps0 += i - targetIndex0;
                targetIndex0++;
            }
            if (nums[i] == 1)
            {// How far is for its target position.
                swaps1 += i - targetIndex1;
                targetIndex1++;
            }
        }

        return Math.Min(swaps0, swaps1);
    }

    /// <summary>
    /// Counts the cost of moving each 0 (or 1) to its sorted position, 
    /// by calculating and accumulating
    /// how many 0s (or 1s) are blocking me on the left, 
    /// then returns the minimum of both.
    /// </summary>
    /// <param name="nums">Binary array containing only 0s and 1s.</param>
    /// <returns>Minimum number of swaps to sort the array.</returns>
    public static int SolveAlt(int[] nums)
    {
        int onesSeen = 0, swaps0Left = 0;
        int zerosSeen = 0, swaps1Left = 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                onesSeen++;
                swaps1Left += zerosSeen;
            }
            else
            {
                zerosSeen++;
                swaps0Left += onesSeen;
            }
        }

        return Math.Min(swaps0Left, swaps1Left);
    }
}

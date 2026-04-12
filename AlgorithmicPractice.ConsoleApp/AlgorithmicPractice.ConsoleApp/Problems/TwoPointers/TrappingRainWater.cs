namespace AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

/// <summary>
/// Given an array peaks where each element represents the height of a bar, 
/// compute how much rain water can be trapped after raining.
/// Pattern: Two Pointers with State
/// Input:  [4,2,0,3,2,5]
///  Output: 9
/// </summary>
public class TrappingRainWater
{
    /// <summary>
    /// - We need to keep track of the heights formed by the peaks
    /// - Process the smaller side.
    ///     - If `peakSide` is higher (or equal), update `maxSide`.
    ///     - Else (if `peakSide` is lower), accumulate water.
    /// - Shift current side pointer.
    /// - Repeat   
    /// <param name="peaks">Array where each element represents the height of a bar</param>
    /// <returns>How much water is trapped.</returns>
    /// </summary>
    public static int SolveCleanedUp(int[] peaks)
    {
        int left = 0;
        int right = peaks.Length - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int water = 0;

        while (left < right)
        {
            // Process smaller side.
            if (peaks[left] < peaks[right])
            {
                if (peaks[left] >= maxLeft)
                    // Update max if peak higher (or equal).
                    maxLeft = peaks[left];
                else
                    // Accumulate water if peak is lower.
                    water += maxLeft - peaks[left];

                left++;
            }
            else
            {
                if (peaks[right] >= maxRight)
                    // Update max if peak higher (or equal).
                    maxRight = peaks[right];
                else
                    // Accumulate water if peak is lower.
                    water += maxRight - peaks[right];

                right--;
            }
        }

        return water;
    }

    public static int Solve(int[] peaks)
    {
        var left = 0;
        var right = peaks.Length - 1;
        var maxLeft = peaks[left];
        var maxRight = peaks[right];
        int current = (maxLeft < maxRight) ? left : right;
        int water = 0;

        while (left < right)
        {
            var lowMax = Math.Min(maxLeft, maxRight);
            var currWater = lowMax - peaks[current];
            water += (currWater > 0) ? currWater : 0;

            if (maxLeft < maxRight)
            {
                left++;
                maxLeft = Math.Max(maxLeft, peaks[left]);
                current = left;
            }
            else
            {
                right--;
                maxRight = Math.Max(maxRight, peaks[right]);
                current = right;
            }
        }

        return water;
    }
}

namespace AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

/// <summary>
/// You are given an integer array `height` of length `n`. 
/// There are `n` vertical lines drawn such that the two endpoints 
/// of the `ith` line are `(i, 0)` and `(i, height[i])`.
/// Find two lines that together with the x-axis form a container, 
/// such that the container contains the most water.
/// Return *the maximum amount of water a container can store*.
/// **Notice** that you may not slant the container.
/// Input: peaks = [1,8,6,2,5,4,8,3,7]
/// Output: 49
/// </summary>
public class ContainerWithMostWater
{
    /// <summary>
    /// Get the `min height` between them.
    /// Calculate the `area` (`min height * distance`)between them. Track `most water`.
    /// Shift **smaller** side pointer.
    /// <param name="peaks">Array where each element represents the height of a bar</param>
    /// <returns>The maximum amount of water a container can store.</returns>
    /// </summary>
    public static int Solve(int[] peaks)
    {
        int left = 0;
        int right = peaks.Length - 1;
        int mostWater = 0;

        while (left < right)
        {
            var distance = right - left;
            var minHeight = Math.Min(peaks[left], peaks[right]);
            var area = minHeight * distance;
            mostWater = Math.Max(mostWater, area);

            // Shift smaller side pointer.
            if (peaks[left] <= peaks[right])
                left++;
            else
                right--;
        }

        return mostWater;
    }
}

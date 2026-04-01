namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

public class MaxSumSubarrayOfSizeK
{
    public static int Solve(int[] nums, int k)
    {
        var maxSum = 0;

        for (var left = 0; left < nums.Length; left++)
        {
            var right = left + k;
            if (right <= nums.Length)
            {
                var sum = 0;
                for (var subL = left; subL < right; subL++)
                {
                    sum += nums[subL];
                }
                maxSum = Math.Max(sum, maxSum);
            }
        }

        return maxSum;
    }
}

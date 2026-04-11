namespace AlgorithmicPractice.ConsoleApp.Problems.BinarySearch;

public class RotatedBinarySearch
{
    public static int Solve(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (target == nums[mid]) return mid;
            // Left half.
            else if (target < nums[mid]
                && target >= nums[left])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}

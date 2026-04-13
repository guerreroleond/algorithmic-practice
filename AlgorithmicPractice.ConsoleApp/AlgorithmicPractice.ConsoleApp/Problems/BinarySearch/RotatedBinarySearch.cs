namespace AlgorithmicPractice.ConsoleApp.Problems.BinarySearch;

/// <summary>
/// [AP011] ** Binary Search **
/// Given a sorted rotated array of numbers 'nums',
/// Find the 'target'.
/// Input:
/// `nums` = [4,5,6,7,0,1,2]
/// `target` = 0
/// Output = 4
/// </summary>
public class RotatedBinarySearch
{
    /// <summary>
    /// Searches for <paramref name="target"/>
    /// in the sorted array <paramref name="nums"/>
    /// using binary search and returns its index, or -1 if not found.
    /// <param name="nums">A sorted *rotated* array of integers.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The zero-based index of <paramref name="target"/>, 
    /// or -1 if not found.
    /// </returns>
    /// </summary>
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
            {// Smaller than mid && greater/equals left.
                right = mid - 1;
            }
            else
            {// Bigger than mid.
                left = mid + 1;
            }
        }

        return -1;
    }
}

namespace AlgorithmicPractice.ConsoleApp.Problems.BinarySearch;

/// <summary>
/// Given a sorted array of numbers `nums`, find the `target`
/// **Inputs:**
/// `nums`: [2,4,6,8,10,12]
/// `target`: 10
/// </summary>
public class BinarySearch
{
    /// <summary>
    /// Searches for <paramref name="target"/> 
    /// in the sorted array <paramref name="nums"/>
    /// using binary search and returns its index, or -1 if not found.
    /// </summary>
    /// <param name="nums">A sorted array of integers.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The zero-based index of <paramref name="target"/>, 
    /// or -1 if not found.
    /// </returns>
    public static int SolveClean(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (target == nums[mid]) return mid;
            else if (target < nums[mid])
            {// Smaller.
                right = mid - 1;
            }
            else
            {// Bigger.
                left = mid + 1;
            }
        }

        return -1;
    }
}

// **Steps:**

// - Find the `middle` element.
//     - Check if is equals to `target`
//         - If yes, return it (SOLVED)
//         - If not, compare
//             - if `target` is `bigger` take second half and repeat the process
//             - If `target` is `smaller` take first half and repeat the process

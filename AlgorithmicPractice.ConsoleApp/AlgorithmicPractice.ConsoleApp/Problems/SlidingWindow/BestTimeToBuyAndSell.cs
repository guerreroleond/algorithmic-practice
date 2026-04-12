using System.ComponentModel.DataAnnotations;

namespace AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

/// <summary>
/// You receive an array `prices` where `prices[i]` represents the stock price on a day `i`. 
/// **Goal**: **Maximize profit** by choosing a single buy day and a single sell day, 
/// with the rule:
/// - You must **buy before you sell**.
/// If no profit is possible, return `0`.
/// Pattern: Two Pointers/Sliding Window
/// Input: `[7,1,5,3,6,4]`
/// Output: `5` (buy at `1`(`i:1`), sell at `6`(`i:4`))
/// </summary>
public class BestTimeToBuyAndSell
{
    /// <summary>
    /// Start with a `valid window`(buy before sell) `left = 0, right = left + 1 = 1`.
    /// Keep track of `minBuy` and `maxSell` .
    /// Calculate `profit`and update `maxProfit`.
    /// Shift pointers to the right.
    /// Repeat.
    /// </summary>
    /// <param name="prices">An array prices 
    /// where prices[i] represents the stock price on a day i. 
    /// </param>
    /// <returns>Max profit by choosing a single buy day and a single sell day,</returns>
    public static int Solve(int[] prices)
    {
        if (prices == null 
        ||  prices.Length < 2) return 0;

        var left = 0;
        var right = left + 1;
        var minBuy = int.MaxValue;
        var maxSell = 0;
        var maxProfit = 0;

        while (left < right && right < prices.Length)
        {
            minBuy = Math.Min(minBuy, prices[left]);
            maxSell = Math.Max(maxSell, prices[right]);
            var profit = maxSell - minBuy;
            maxProfit = Math.Max(maxProfit, profit);
            left++;
            right++;
        }

        return maxProfit;
    }
}

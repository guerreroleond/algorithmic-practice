namespace AlgorithmicPractice.ConsoleApp.Problems.DynamicProgramming;

/// <summary>
/// **Dynamic Programming | Medium**
/// You are given an integer array `coins` representing coins of different 
/// denominations and an integer `amount` representing a total amount of money.
/// Return *the fewest number of coins that you need to make up that amount*. 
/// If that amount of money cannot be made up by any combination of the coins, return `-1`.
/// You may assume that you have an infinite number of each kind of coin.
/// **Example 1:**
/// Input: coins = [1,3,4,5], amount = 7
/// Output: 2
/// Explanation: 7 = 3 + 4 
/// </summary>
public class CoinChange
{
    /// <summary>
    /// Need to calculate possible solutions from amounts 0 (`base case`) up to `amount`.
    /// Create an array `fewestCoins[a]` to store posible solutions for each amount.
    /// Initialize `base case` → `fewestCoins[0]= 0`.
    /// Initialize remaining amounts with a `huge number{int.MaxValue}` 
    /// because we are calculating `minimums{fewestCoins}`.
    /// Traverse all `amounts` to calculate `fewestCoins`.
    /// Validate each `coin`, must be smaller or equals to `current amount{a}`. 
    /// Use this `coin` + `fewestCoins[remainingAmount{a - coin}]`.
    /// </summary>
    /// <param name="coins">Array of coins representing different denominations.</param>
    /// <param name="amount">Total amount of money.</param>
    /// <returns>The fewest number of coins that needed to make up that amount.</returns>
    public static int Solve(int[] coins, int amount)
    {
        // Fewest coins to make amount a.
        // Represent all amounts from 0 up to amount (inclusive);
        int[] fewestCoins = new int[amount + 1];

        // Initialize with huge number.
        for (int a = 1; a <= amount; a++)
            fewestCoins[a] = int.MaxValue;

        fewestCoins[0] = 0; // base case.

        for (int a = 1; a <= amount; a++)
        {
            foreach (var coin in coins)
            {
                // Don't use coins bigger than current amount.
                if (coin <= a)
                {
                    fewestCoins[a] = Math.Min(
                        fewestCoins[a], fewestCoins[a - coin] + 1);
                }
            }
        }

        return fewestCoins[amount] > amount
                ? -1
                : fewestCoins[amount];
    }
}

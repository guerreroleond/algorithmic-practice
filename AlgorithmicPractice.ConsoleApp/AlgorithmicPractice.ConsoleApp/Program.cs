// See https://aka.ms/new-console-template for more information
using AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;
using AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

Console.WriteLine("Algorithmic Practice");


// #region Sliding Window - Longest Substring Without Repeating
//
// var input = "VDFVABCDAJKLCB";
//
// var result = LongestSubstringWithoutRepeating.Solve(input);
//
// Console.WriteLine($" longest substring length {result}");
//
// #endregion Sliding Window - Longest Substring Without Repeating

// #region Sliding Window - Longest Repeating Character Replacement
//
// var input = "AABBBCACCCD";
// var k = 2;
//
// Console.WriteLine(
//     $"Debug placeholder for {nameof(LongestRepeatingCharacterReplacement)}" +
//                     $"with input '{input}' and k={k}.");
//
// var result = LongestRepeatingCharacterReplacement
//                 .SolveStringCleanedUp(input, k);
//
// Console.WriteLine($" Longest repeating substring {result}");
// Console.ReadLine();
//
// #endregion Sliding Window - Longest Repeating Character Replacement

#region Two Pointers - Two Sum II

var numbers = new int[] { 2, 7, 11, 15 };

var result = TwoSumII.Solve(numbers, 26);

Console.WriteLine($"Two Sum II result: [{string.Join(", ", result)}]");
Console.ReadLine();

#endregion Two Pointers - Two Sum II
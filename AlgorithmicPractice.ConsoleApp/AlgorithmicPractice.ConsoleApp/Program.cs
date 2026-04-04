// See https://aka.ms/new-console-template for more information
using AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

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

#region Sliding Window - Longest Repeating Character Replacement

var input = "AABBBCACCCD";
var k = 2;

Console.WriteLine(
    $"Debug placeholder for {nameof(LongestRepeatingCharacterReplacement)}" +
                    $"with input '{input}' and k={k}.");

var result = LongestRepeatingCharacterReplacement
                .SolveString(input, k);

Console.WriteLine($" Longest repeating substring {result}");
Console.ReadLine();

#endregion Sliding Window - Longest Repeating Character Replacement
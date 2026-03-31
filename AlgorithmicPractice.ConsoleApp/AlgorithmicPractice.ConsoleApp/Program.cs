// See https://aka.ms/new-console-template for more information
using AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;

Console.WriteLine("Algorithmic Practice");


#region Sliding Window - Longest Substring Without Repeating

var input = "VDFVABCDAJKLCB";

var result = LongestSubstringWithoutRepeating.Solve(input);

Console.WriteLine($" longest substring length {result}");

#endregion Sliding Window - Longest Substring Without Repeating
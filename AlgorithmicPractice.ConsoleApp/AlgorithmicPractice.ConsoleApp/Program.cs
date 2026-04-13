// See https://aka.ms/new-console-template for more information
using AlgorithmicPractice.ConsoleApp.Problems.BinarySearch;
using AlgorithmicPractice.ConsoleApp.Problems.DynamicProgramming;
using AlgorithmicPractice.ConsoleApp.Problems.Sorting;
using AlgorithmicPractice.ConsoleApp.Problems.DataStructures.LinkedList;
using AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;
using AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

Console.WriteLine("Algorithmic Practice");

#region [AP001] Sliding Window - Longest Substring Without Repeating

// var input = "VDFVABCDAJKLCB";
//
// var result = LongestSubstringWithoutRepeating.Solve(input);
//
// Console.WriteLine($" longest substring length {result}");

#endregion [AP001] Sliding Window - Longest Substring Without Repeating

#region [AP003] Sliding Window - Longest Repeating Character Replacement

// var input = "AABBBCACCCCD";
// var k = 2;
//
// var result = LongestRepeatingCharacterReplacement
//                 .Solve(input, k);
//
// Console.WriteLine($" Longest repeating substring {result}");

#endregion [AP003] Sliding Window - Longest Repeating Character Replacement

#region Two Pointers - Two Sum II
//
// var numbers = new int[] { 2, 7, 11, 15 };
//
// var result = TwoSumII.Solve(numbers, 26);
//
// Console.WriteLine($"Two Sum II result: [{string.Join(", ", result)}]");
//
#endregion Two Pointers - Two Sum II

#region Two Pointers - Valid Palindrome
// var input = "A man, a plan, a canal: Panama";

// var result = ValidPalindrome.Solve(input);

// Console.WriteLine($"Valid Palindrome result: {result}");

#endregion Two Pointers - Valid Palindrome

#region [AP006] Two Pointers - Trapping Rain Water

// var peaks = new int[] { 4,2,0,3,2,5 };
//
// var trappedWater = TrappingRainWater.SolveCleanedUp(peaks);
//
// Console.WriteLine($"Trapping Rain Water result: {trappedWater}");

#endregion [AP006] Two Pointers - Trapping Rain Water

#region Linked List - (Singly) Max Pages
//
// var head = new SinglyLinkedListNode { PagesCount = 1, Next = new SinglyLinkedListNode { PagesCount = 4, Next = new SinglyLinkedListNode { PagesCount = 3, Next = new SinglyLinkedListNode { PagesCount = 5, Next = new SinglyLinkedListNode { PagesCount = 6, Next = new SinglyLinkedListNode { PagesCount = 2 } } } } } };
//
// //var result = SinglyLinkedListMaxPages.RemoveNthNodeFromEnd(head, 1);
// //var result = SinglyLinkedListMaxPages.Reverse(head);
//
// var result = SinglyLinkedListMaxPages.MaxPages(head);
//
// Console.WriteLine($"Singly Linked List Max Pages result: {result}");
//
#endregion Linked List - (Singly) Max Pages

#region Linked List - Remove Nth Node From End
//
// var head = new SinglyLinkedListNode { PagesCount = 1, Next = new SinglyLinkedListNode { PagesCount = 2, Next = new SinglyLinkedListNode { PagesCount = 3, Next = new SinglyLinkedListNode { PagesCount = 4, Next = new SinglyLinkedListNode { PagesCount = 5 } } } } };
//
// var result = RemoveNthNodeFromEnd.Solve(head, 2);
//
// Console.WriteLine($"Remove Nth Node From End result head PagesCount: {result?.PagesCount}");
//
#endregion Linked List - Remove Nth Node From End

#region [AP009] Sorting - Sort Binary Array And Min Swaps

// var nums = new int[] { 1, 0, 0, 0, 1, 0, 0, 1 };
//
// var result = SortBinaryArrayAndMinSwaps.Solve(nums);
//
// Console.WriteLine($"Sort Binary Array Min Swaps result: {result}");

#endregion [AP009] Sorting - Sort Binary Array And Min Swaps

#region Binary Search - Basic Binary Search

// var nums = new int[] { 2,4,5,6,8,9,10,12 };
//
// var result = BinarySearch.SolveClean(nums, 5);
//
// Console.WriteLine($"Binary Search result: i[{result}] = {nums[result]}");

#endregion Binary Search - Basic Binary Search

#region [AP011] Binary Search - Rotated Binary Search

var nums = new int[] { 4,5,6,7,0,1,2 };
var target = 5;

var result = RotatedBinarySearch.Solve(nums, target);

Console.WriteLine($"Rotated Binary Search result: {result}");

#endregion [AP011] Binary Search - Rotated Binary Search

#region Sliding Window - Best Time To Buy And Sell

// var prices = new int[] { 7, 1, 5, 3, 6, 4 };

// var result = BestTimeToBuyAndSell.Solve(prices);

// Console.WriteLine($"Best Time To Buy And Sell result: {result}");

#endregion Sliding Window - Best Time To Buy And Sell

#region [AP013] Two Pointers - Container With Most Water

// var peaks = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
//
// var result = ContainerWithMostWater.Solve(peaks);
//
// Console.WriteLine($"Container With Most Water result: {result}");

#endregion [AP013] Two Pointers - Container With Most Water

#region [AP014] Dynamic Programming - Climbing Stairs

// var steps = 5;
//
// var result = ClimbingStairs.SolveIterative(steps);
//
// Console.WriteLine($"Climbing Stairs result: {result}");

#endregion [AP014] Dynamic Programming - Climbing Stairs

#region [AP015] Dynamic Programming - Coin Change

// var coins = new int[] { 1, 5, 10, 25 };
// var amount = 41;
//
// var coins = new int[] { 1, 3, 4, 5 };
// var amount = 7;
//
// var result = CoinChange.Solve(coins, amount);
//
// Console.WriteLine($"Coin Change result: {result}");

#endregion [AP015] Dynamic Programming - Coin Change

Console.ReadLine();
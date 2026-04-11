// See https://aka.ms/new-console-template for more information
using AlgorithmicPractice.ConsoleApp.Problems.Sorting;
using AlgorithmicPractice.ConsoleApp.Problems.DataStructures.LinkedList;
using AlgorithmicPractice.ConsoleApp.Problems.SlidingWindow;
using AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

Console.WriteLine("Algorithmic Practice");

#region Sliding Window - Longest Substring Without Repeating
//
// var input = "VDFVABCDAJKLCB";
//
// var result = LongestSubstringWithoutRepeating.Solve(input);
//
// Console.WriteLine($" longest substring length {result}");
//
#endregion Sliding Window - Longest Substring Without Repeating

#region Sliding Window - Longest Repeating Character Replacement
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
//
#endregion Sliding Window - Longest Repeating Character Replacement

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

#region Two Pointers - Trapping Rain Water
//
// var peaks = new int[] { 4,2,0,3,2,5 };
//
// var trappedWater = TrappingRainWater.Solve(peaks);
//
// Console.WriteLine($"Trapping Rain Water result: {trappedWater}");
//
#endregion Two Pointers - Trapping Rain Water

#region Hybrid - Singly Linked List Max Pages
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
#endregion Hybrid - Singly Linked List Max Pages

// #region LinkedList - Remove Nth Node From End
//
// var head = new SinglyLinkedListNode { PagesCount = 1, Next = new SinglyLinkedListNode { PagesCount = 2, Next = new SinglyLinkedListNode { PagesCount = 3, Next = new SinglyLinkedListNode { PagesCount = 4, Next = new SinglyLinkedListNode { PagesCount = 5 } } } } };
//
// var result = RemoveNthNodeFromEnd.Solve(head, 2);
//
// Console.WriteLine($"Remove Nth Node From End result head PagesCount: {result?.PagesCount}");
//
// #endregion LinkedList - Remove Nth Node From End

#region Sorting - Sort Binary Array And Min Swaps

var nums = new int[] { 1, 0, 0, 0, 1, 0, 0, 1 };

//var nums = new int[] { 0, 1, 0, 1};

var result = SortBinaryArrayAndMinSwaps.SolveAlt(nums);

Console.WriteLine($"Sort Binary Array Min Swaps result: {result}");

#endregion Sorting - Sort Binary Array And Min Swaps

Console.ReadLine();
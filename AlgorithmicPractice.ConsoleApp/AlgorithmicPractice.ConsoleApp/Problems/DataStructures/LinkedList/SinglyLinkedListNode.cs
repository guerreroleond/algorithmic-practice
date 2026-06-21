namespace AlgorithmicPractice.ConsoleApp.Problems.DataStructures.LinkedList;

public class SinglyLinkedListNode
{
    public int PagesCount { get; set; }
    public SinglyLinkedListNode? Next { get; set; }

    public static SinglyLinkedListNode? Reverse(SinglyLinkedListNode inputHead)
    {
        SinglyLinkedListNode? prev = null;
        var current = inputHead;

        while (current != null)
        {
            // Save next before breaking the links.
            var next = current.Next;
            // Reverse.
            current.Next = prev;
            // Shift pointers.
            prev = current;
            current = next;
        }

        return prev;
    }
}

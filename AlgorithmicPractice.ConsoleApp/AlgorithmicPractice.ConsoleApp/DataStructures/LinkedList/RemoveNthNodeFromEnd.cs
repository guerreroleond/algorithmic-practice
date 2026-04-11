namespace AlgorithmicPractice.ConsoleApp.DataStructures.LinkedList;

public class RemoveNthNodeFromEnd
{
    
    /// <summary>
    /// Given the head of a linked list, 
    /// remove the nth node from the end of the list and return its head.
    /// </summary>
    /// <param name="head">The head of a linked list.</param>
    /// <param name="n">The Nth node from the end to remove.</param>
    /// <returns>The head of the list without the Nth node.</returns>
    public static SinglyLinkedListNode? Solve(
        SinglyLinkedListNode head, int n)
    {
        var dummy = new SinglyLinkedListNode
        {
            Next = head
        };

        var left = dummy;
        var right = head;
        // Create the gap.
        while (n > 0 && right != null)
        {
            right = right.Next;
            n -= 1;
        }
        // Move together.
        // Only moving pointers.
        while (right != null)
        {
            left = left.Next;
            right = right.Next;
        }
        // Mutation happens.
        left.Next = left.Next.Next;

        return dummy.Next;
    }
}

namespace AlgorithmicPractice.ConsoleApp.Problems.DataStructures.LinkedList;

public class SinglyLinkedListMaxPages
{
    public static int MaxPages(SinglyLinkedListNode head)
    {
        if(head == null) return 0;

        // 1. Find middle (slow will be at  start of second half for even length)
        var slow = head;
        var fast = head;

        while(fast != null && fast.Next != null
           && slow != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        // 2. Reverse second half starting at slow.
        var secondHalf = Reverse(slow);

        // 3. Traverse both halves.
        var firstHalf = head;
        int maxPages = 0;

        while(secondHalf != null)
        {
            int sum = firstHalf.PagesCount + secondHalf.PagesCount;
            maxPages = Math.Max(maxPages, sum);

            firstHalf = firstHalf.Next;
            secondHalf = secondHalf.Next;
        }

        return maxPages;
    }

    public static SinglyLinkedListNode? Reverse(SinglyLinkedListNode linkedList)
    {
        SinglyLinkedListNode? prev = null;
        var current = linkedList;

        while(current != null)
        {
            // Move and Save next before breaking the links.
            var next = current.Next;
            // For current, take its next and reverse it.
            current.Next = prev;
            // Shift pointers.
            prev = current;
            current = next;
        }

        return prev;
    }

    public static int MaximumPages(SinglyLinkedListNode head)
    {
        var current = head;
        var maxCount = 0;

        while(current != null)
        {
            if(current.Next != null)
            {
                // Save the first node pages.
                var pagesCount = current.PagesCount;
                // Remove first.
                head = current.Next;
                pagesCount += GetLastNodePagesAndRemove(head);
                maxCount = Math.Max(pagesCount, maxCount);
            }
            current = current.Next;
        }

        return maxCount;
    }

    public static int GetLastNodePagesAndRemove(SinglyLinkedListNode? head)
    {
        var current = head;
        var nodeList = new List<SinglyLinkedListNode>();
        var pagesCount = 0;

        while(current != null)
        {
            nodeList.Add(current);
            current = current.Next;
        }

        if(nodeList.Count == 1)
        {
            head = null;
            pagesCount = nodeList[0].PagesCount;
            nodeList[0] = nodeList[0].Next;
            nodeList.Clear();
        }
        else
        {
            pagesCount = nodeList[nodeList.Count - 1].PagesCount;
            // Remove last.
            nodeList[nodeList.Count - 1 - 1].Next = nodeList[nodeList.Count - 1].Next;
        }

        return pagesCount;
    }
}

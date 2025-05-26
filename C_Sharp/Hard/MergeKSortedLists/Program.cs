public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
public class Solution {
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0) return null;

        ListNode temp = lists[0];
        for (int i = 1; i < lists.Length; i++) {
            ListNode one = temp;
            ListNode two = lists[i];
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (one != null && two != null) 
            {
                if (one.val <= two.val) 
                {
                    current.next = one;
                    one = one.next;
                } else 
                {
                    current.next = two;
                    two = two.next;
                }
                current = current.next;
            }

            current.next = (one != null) ? one : two;
            temp = dummy.next;
        }

        return temp;
    }
}

class Program
{
    static void Main()
    {
        var n3 = new ListNode(5);
        var n2 = new ListNode(4, n3);
        var n1 = new ListNode(1, n2);

        var n6 = new ListNode(4);
        var n5 = new ListNode(3, n6);
        var n4 = new ListNode(1, n5);

        var n8 = new ListNode(6);
        var n7 = new ListNode(2, n8);

        var nodes = new ListNode[] { n1, n4, n7 };
        
        Solution solution = new Solution();
        ListNode result = solution.MergeKLists(nodes);

        while (result != null) 
        {
            Console.Write(result.val + " -> ");
            result = result.next;
        }
        Console.WriteLine("null");

    }
}
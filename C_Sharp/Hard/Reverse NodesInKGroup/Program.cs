using System;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode node = head;
        int count = 0;

        while (node != null && count < k) {
            node = node.next;
            count++;
        }

        if (count < k)
            return head;

        ListNode final = null;
        ListNode temp;
        ListNode current = head;
        count = 0;

        while (current != null && count < k) {
            temp = current.next;
            current.next = final;
            final = current;
            current = temp;
            count++;
        }

        if (current != null)
            head.next = ReverseKGroup(current, k);

        return final;
    }
}

class Program {
    static void Main() {
        var N5 = new ListNode(5);
        var N4 = new ListNode(4, N5);
        var N3 = new ListNode(3, N4);
        var N2 = new ListNode(2, N3);
        var N1 = new ListNode(1, N2);

        var sol = new Solution();
        var result = sol.ReverseKGroup(N1, 2);

        while (result != null) {
            Console.Write(result.val + " ");
            result = result.next;
        }
    }
}
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
       if(head == null || head.next == null)
       return;

       //Find middle of linkedlist
       var slow = head;
       var fast = head;
       while(fast.next!=null && fast.next.next!=null)
       {
            slow = slow.next;
            fast = fast.next.next;
       }
       // =>slow pointer is at the middle

        //reversing other half linked list
        var preMiddle = slow;
        var preCurrent = preMiddle.next; // next node to middle node
        while(preCurrent.next!=null)
        {
            var curr = preCurrent.next;
            preCurrent.next = curr.next;
            curr.next = preMiddle.next;
            preMiddle.next = curr;
        }

    // reordering
        var p1 = head;
        var p2 = preMiddle.next;

        while(p1!=preMiddle)
        {
            preMiddle.next = p2.next;
            p2.next = p1.next;
            p1.next = p2;
            p1 = p2.next;
            p2 = preMiddle.next;
        }
    }
}

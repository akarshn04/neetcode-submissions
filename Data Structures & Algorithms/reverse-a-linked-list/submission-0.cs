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
    public ListNode ReverseList(ListNode head) {
        if(head == null)
            return head;
        var temp = head;
        ListNode prev = null;

        while(temp.next!=null)
        {
            var nextNode = temp.next;
            temp.next = prev;
            prev = temp;
            temp = nextNode;
        }
        temp.next = prev;
        return temp;

    }
}

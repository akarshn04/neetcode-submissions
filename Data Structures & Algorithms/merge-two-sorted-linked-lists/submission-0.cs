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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null)
            return list2;
        else if(list2 == null)
            return list1;
        else if(list1 == null && list2 == null)
        {
            return null;
        }
        var head1 = list1;
        var head2 = list2;
        ListNode head = null;
        ListNode node = null;

        while(head1!=null && head2!=null)
        {
            if(head == null)
            {
                head=new ListNode();
                node=head;
            }
            if(head1.val<head2.val)
            {
                node = AddAndReturnNode(node,head1);
                head1=head1.next;
            }
            else if(head1.val>head2.val)
            {
                node = AddAndReturnNode(node,head2);
                head2=head2.next;
            }
            else
            {
                node = AddAndReturnNode(node,head1);
                node = AddAndReturnNode(node,head2);
                head1 = head1.next;
                head2 = head2.next;
            }
        }
        while(head1!=null)
        {
            node = AddAndReturnNode(node,head1);
            head1 = head1.next;
        }
        while(head2!=null)
        {
            node =AddAndReturnNode(node,head2);
            head2 = head2.next;
        }
        return head.next;
    }
    private ListNode AddAndReturnNode(ListNode node, ListNode newNode)
    {
        var freshNode = new ListNode(newNode.val);
        node.next = freshNode;
        return freshNode;
    }
}
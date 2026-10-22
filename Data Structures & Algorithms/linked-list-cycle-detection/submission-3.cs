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
    public bool HasCycle(ListNode head) {
        ListNode f = head;
        ListNode s = head;
        if(head == null) return false;
        if(head.next == null) return false;

        if(f.next != null && f.next.next != null){
            f = f.next.next;
            s = s.next;
        }else if(f.next != null && f.next.next == null){
            return false;
        }

        while(f != s){
            if(f.next != null && f.next.next != null){
                f = f.next.next;
                s = s.next;
            }else{
                return false;
            }
        }
        return true;

    }
}

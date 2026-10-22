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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int len = 1;
        ListNode cur = head;
        while(cur.next != null){
            len++;
            cur = cur.next;
        }
        int rem = len - n + 1;
        if(rem == 1) return head.next;

        ListNode prev = null;
        cur = head;
        while( rem > 1){
            prev = cur;
            cur = cur.next;
            rem--;
        }
        prev.next = cur.next;
        return head;
    }
}

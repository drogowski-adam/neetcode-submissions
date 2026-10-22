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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0) return null;

        while(lists.Length > 1){
            List<ListNode> mergedLists = new List<ListNode>();
            for(int i = 0; i < lists.Length; i+= 2){
                ListNode l1 = lists[i];
                ListNode l2 = i+1 < lists.Length ? lists[i+1] : null;
                mergedLists.Add(MergeList(l1,l2));
            }
            lists = mergedLists.ToArray();
        }
        return lists[0];


    }

    public ListNode MergeList(ListNode l1, ListNode l2){
        if(l1 == null) return l2;
        if(l2 == null) return l1;

        if(l1.val <= l2.val){
            l1.next = MergeList(l1.next,l2);
            return l1;
        }
        else{
            l2.next = MergeList(l1,l2.next);
            return l2;
        }
    }
}

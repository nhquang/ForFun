//https://leetcode.com/problems/linked-list-cycle/


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        var curr = head;
        while(curr != null){
            if(set.Contains(curr)) return true;
            set.Add(curr);
            curr = curr.next;
        }
        return false;
    }
}
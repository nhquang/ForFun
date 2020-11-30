//https://leetcode.com/problems/remove-duplicates-from-sorted-list/




public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var current = head;
        ListNode prev = null;
        while(current != null){
            if(prev != null && current.val == prev.val)
                prev.next = current.next;
            else
                prev = current;
            current = current.next;
        }
        return head;
    }
}
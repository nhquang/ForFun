//https://leetcode.com/problems/palindrome-linked-list/


public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode newHead = null, current = head;
        while(current != null){
            if(current == head) newHead = new ListNode(current.val);
            else newHead = new ListNode(current.val, newHead);
            current = current.next;
        }
        var current2 = newHead;
        current = head;
        while(current2 != null && current != null){
            if(current == null || current2 == null) return false;
            if(current.val != current2.val) return false;
            
            current2 = current2.next;
            current = current.next;
        }
        return true;
    }
}
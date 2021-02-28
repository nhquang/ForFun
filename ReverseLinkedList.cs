//https://leetcode.com/problems/reverse-linked-list/



public class Solution {
    //O(n) space
    public ListNode ReverseList(ListNode head) {
        var current = head;
        ListNode newHead = null;
        
        while(current != null){
            newHead = new ListNode(current.val, newHead);
            current = current.next;
        }
        return newHead;
    }
	//O(1) space
	public ListNode ReverseList1(ListNode head) {
        var current = head;
        ListNode prev = null;
        while(current != null){
            var nextNode = current.next;
            current.next = prev;
            prev = current;
            current = nextNode;
        }
        return prev;
    }
	public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
}
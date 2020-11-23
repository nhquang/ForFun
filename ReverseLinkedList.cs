//https://leetcode.com/problems/reverse-linked-list/



public class Solution {
    
    public ListNode ReverseList(ListNode head) {
        var current = head;
        ListNode newHead = null;
        
        while(current != null){
            if(current == head)
                newHead = new ListNode(current.val, null);
            else
                newHead = new ListNode(current.val, newHead);
			
            current = current.next;
        }
        return newHead;
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
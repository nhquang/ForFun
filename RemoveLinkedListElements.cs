
	//https://leetcode.com/problems/remove-linked-list-elements/
	
	
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
	
	
	public ListNode RemoveElements(ListNode head, int val) {
        var curr = head;
        ListNode prev = null;
        while (curr != null)
        {
            if(curr.val == val){
                if(prev != null) prev.next = curr.next;
                else head = curr.next;
                curr = curr.next;
                continue;
            }
            prev = curr;
            curr = curr.next;
        }
        return head;
    }	
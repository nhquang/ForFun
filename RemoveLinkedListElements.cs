
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
            var current = head;
            ListNode prev = null;
            while (current != null)
            {
                bool skip = false;
                if(current.val == val)
                {
                    if (current.next == null)
                    {
                        if (current == head) current = head = null;
                        else prev.next = current = null;
                    }
                    else
                    {
                        if (current == head) head = current.next;
                        else{
                            prev.next = current.next;
                            skip = true;
                        }
                    }
                }
                if(!skip) prev = current;
                if(current != null) current = current.next;
                
            }
            return head;
    }	
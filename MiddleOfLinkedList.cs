	//https://leetcode.com/problems/middle-of-the-linked-list/

	public ListNode MiddleNode(ListNode head) {
        int count = 0;
        var current = head;
        while(current != null){
            count++;
            current = current.next;
        }
        count /= 2;
        int count2 = 0;
        current = head;
        while(current != null){
            
            if(count2 == count) return current;
            current = current.next;
            count2++;
        }
        return null;
    }
	
	
	
	//better
	public ListNode MiddleNode(ListNode head) {
        var slow = head; var fast = head;
        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
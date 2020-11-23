



		
public class Solution {
    
    public ListNode PopulateALinkedList(List<int> data)
    {

        ListNode newHead = null, current = null;
        if (data.Count == 0) return newHead;
            
        for (int i = 0; i < data.Count; i++)
        {
            if (i == 0) {
                newHead = new ListNode(data[i]);
                current = newHead;
            }
            else
            {
                current.next = new ListNode(data[i]);
                current = current.next;
            }
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
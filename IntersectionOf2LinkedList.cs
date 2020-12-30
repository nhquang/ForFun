//https://leetcode.com/problems/intersection-of-two-linked-lists/


public class Solution {
    //brute force
	public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var currA = headA;
        var currB = headB;
        while(currA != null){
            while(currB != null){
                if(currA == currB) return currA;
                currB = currB.next;
            }
            currA = currA.next;
            currB = headB;
        }
        return null;
    }
	
	//O(m+n)
	public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var set = new HashSet<ListNode>();
        ListNode curr = headA;
        while(curr != null){
            set.Add(curr);
            curr = curr.next;
        }
        curr = headB;
        while(curr != null){
            if(set.Contains(curr)) return curr;
            curr = curr.next;
        }
        return null;
    }
}
//https://leetcode.com/problems/intersection-of-two-linked-lists/


public class Solution {
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
}
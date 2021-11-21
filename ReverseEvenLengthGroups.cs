//https://leetcode.com/problems/reverse-nodes-in-even-length-groups/

public class Solution {
    int groups = 1;
    int temp = 0;
    public ListNode ReverseEvenLengthGroups(ListNode head) {
        int length = 0, tempLength = 1;
        var curr = head;
        ListNode lastGroup = curr;
        while (curr != null)
        {
            length++;
            curr = curr.next;
        }
        curr = head;
        while (curr != null)
        {
            if (length - temp <= tempLength - 2)
            {
                if((length - temp) % 2 == 0)
                    tempLength = Reverse(ref curr, ref lastGroup);
                else
                    tempLength = Skip(ref curr, ref lastGroup);
            }
            else if (groups % 2 != 0)
                tempLength = Skip(ref curr, ref lastGroup);
            else
                tempLength = Reverse(ref curr, ref lastGroup);
            groups++;
        }
        return head;
    }
    
    int Reverse(ref ListNode curr, ref ListNode lastGroup){
        ListNode reversed = curr, prev = null, lastNode = null;
        int tempLength = 1;
        while (reversed != null && tempLength++ <= groups)
        {
            if (tempLength == 2) lastNode = reversed;
            temp++;
            var next = reversed.next;
            reversed.next = prev;
            prev = reversed;
            reversed = next;
        }
        lastNode.next = reversed;
        lastGroup.next = prev;
        lastGroup = lastNode;
        curr = lastNode.next;
        return tempLength;
    }
    int Skip(ref ListNode curr, ref ListNode lastGroup){
        int tempLength = 1;
        while (curr != null && tempLength++ <= groups)
        {
            temp++;
            lastGroup = curr;
            curr = curr.next;
        }
        return tempLength;
    }
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
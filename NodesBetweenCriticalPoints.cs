//https://leetcode.com/problems/find-the-minimum-and-maximum-number-of-nodes-between-critical-points/

public class Solution {
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        int prev = -1, idx = 0;
        var sorted = new SortedSet<int>();
        var curr = head;
        while(curr.next != null){
            if(idx++ != 0){
                if(curr.val < prev && curr.val < curr.next.val)
                    sorted.Add(idx);
                else if(curr.val > prev && curr.val > curr.next.val)
                    sorted.Add(idx);
            }
            prev = curr.val;
            curr = curr.next;
        }
        if(sorted.Count < 2)
            return new int[2]{-1, -1};
        var min = int.MaxValue;
        prev = -1;
        foreach(var item in sorted){
            if(prev != -1)
                min = Math.Min(item - prev, min);
            prev = item;
        }
        return new int[2] { min, sorted.Max - sorted.Min };
    }
}
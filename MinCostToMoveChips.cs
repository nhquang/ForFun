//https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/

// if the chip is at even position, it takes 0 steps to move the chip to position 2.
// if the chip is at odd position, it takes 0 steps to move the chip to position 1.
// move all chips from pos 1 to pos 2 or pos 2 to pos 1.

public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int pos1 = 0, pos2 = 0;
        foreach(var item in position){
            if(item % 2 == 0) pos2++;
            else pos1++;
        }
        return Math.Min(pos1, pos2);
    }
}
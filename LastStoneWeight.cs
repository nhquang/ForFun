//https://leetcode.com/problems/last-stone-weight/

public class Solution {
    public int LastStoneWeight(int[] stones) {
        int i = stones.Length - 1;
        while(true){
            Array.Sort(stones);
            if(stones[i] == 0) break;
            int j = stones.Length - 2; 
            while(j >= 0 && stones[j] == 0) j--;
            if(j < 0) return stones[i];
            stones[i] = stones[i] - stones[j];
            stones[j] = 0;
            
        }
        return 0;
    }
}
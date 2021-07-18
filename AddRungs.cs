//https://leetcode.com/problems/add-minimum-number-of-rungs/


public class Solution {
    public int AddRungs(int[] rungs, int dist) {
        int prev = 0, rs = 0;
        for(int i = 0; i < rungs.Length; i++){
            if(rungs[i] - prev > dist){
                int temp = (rungs[i] - prev) / dist;
                rs += temp;
                if((rungs[i] - prev) % dist == 0) rs--;
            }
            prev = rungs[i];
        }
        return rs;
    }
}
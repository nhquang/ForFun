//https://leetcode.com/problems/eliminate-maximum-number-of-monsters/

public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        for(int i = 0; i < dist.Length; i++){
            int extraSec = dist[i] % speed[i] == 0 ? 0 : 1;
            dist[i] = dist[i] / speed[i] + extraSec;
        }
        Array.Sort(dist);
        int rs = 0;
        int min = 1;
        for(int i = 0; i < dist.Length && dist[i] >= min; i++){
            rs++;
            min++;
        }
        return rs;
    }
}
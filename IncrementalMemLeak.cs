//https://leetcode.com/problems/incremental-memory-leak/

public class Solution {
    public int[] MemLeak(int memory1, int memory2) {
        int[] rs = new int[3];
        int i = 1;
        while(i <= memory1 || i <= memory2){
            if(memory1 >= memory2) memory1 -= i;
            else memory2 -= i;
            i++;
        }
        rs[0] = i;
        rs[1] = memory1;
        rs[2] = memory2;
        return rs;
    }
}
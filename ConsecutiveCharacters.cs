//https://leetcode.com/problems/consecutive-characters/

public class Solution {
    public int MaxPower(string s) {
        int max = 0, count = 0;
        char temp = s[0];
        for(int i = 0; i < s.Length; i++){
            if(s[i] == temp) count++;
            else count = 1;
            max = Math.Max(count, max);
            temp = s[i];
        }
        return max;
    }
}
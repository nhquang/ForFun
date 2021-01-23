//https://leetcode.com/problems/maximum-score-after-splitting-a-string/
public class Solution {
    public int MaxScore(string s) {
        int max = 0, i = 0;
        foreach(var item in s) if(item == '1') sum2++;
        while(i < s.Length - 1){
            if(s[i] == '0') sum1++;
            else sum2--;
            i++;
            max = Math.Max(sum1+sum2, max);
        }
        return max;
    }
}
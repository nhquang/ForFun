//https://leetcode.com/problems/determine-if-string-halves-are-alike/


public class Solution {
    public bool HalvesAreAlike(string s) {
        var b = s.Substring(s.Length / 2, s.Length / 2);
        var temp = "aeiou";
        int sum1 = 0, sum2 = 0;
        for(int i = 0; i < s.Length / 2; i++){
            if(temp.Contains(Char.ToLower(s[i]))) sum1++;
            if(temp.Contains(Char.ToLower(b[i]))) sum2++;
        }
        return sum1 == sum2;
    }
}
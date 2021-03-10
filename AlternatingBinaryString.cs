//https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/

public class Solution {
    public int MinOperations(string s) {
        int count1 = 0, count2 = 1;
        char prev1 = '\0', prev2 = s[0] == '0' ? '1' : '0';
        for (int i = 0; i < s.Length; i++)
        {
            if (prev1 == s[i] && prev1 != '\0')
            {
                prev1 = s[i] == '0' ? '1' : '0';
                count1++;
            }
            else prev1 = s[i];
            if (i != 0 && prev2 == s[i])
            {
                prev2 = s[i] == '0' ? '1' : '0';
                count2++;
            }
            else if (i != 0) prev2 = s[i];
        }
            
        return Math.Min(count1,count2);
    }
}
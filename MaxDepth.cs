//https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/

public class Solution {
    public int MaxDepth(string s) {
        int maxDepth = 0, currDepth = 0;
        for(int i = 0; i < s.Length;i++){
            if(s[i] == '(')
                maxDepth = Math.Max(maxDepth, ++currDepth);
            else if(s[i] == ')')
                currDepth--;
        }
        return maxDepth;
    }
}
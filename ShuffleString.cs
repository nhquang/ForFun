//https://leetcode.com/problems/shuffle-string/



public class Solution {
    public string RestoreString(string s, int[] indices) {
        var sb = new StringBuilder(s);
        
        for(int i = 0; i < sb.Length; i++)
            sb[indices[i]] = s[i];
        
        return sb.ToString();
    }
}
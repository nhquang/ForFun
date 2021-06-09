//https://leetcode.com/problems/thousand-separator/


public class Solution {
    public string ThousandSeparator(int n) {
        var s = n.ToString();
        if(s.Length < 4) return s;
        string rs = "";
        int count = 0;
        for(int i = s.Length - 1; i >= 0; i--){
            rs = (++count % 3 == 0 ? "." : "") + s[i] + rs;
        }
        return rs.TrimStart('.');
    }
}
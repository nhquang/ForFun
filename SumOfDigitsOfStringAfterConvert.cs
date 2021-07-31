//https://leetcode.com/problems/sum-of-digits-of-string-after-convert/

public class Solution {
    public int GetLucky(string s, int k) {
        var res = string.Empty;
        foreach(var c in s){
            int temp = c - '`';
            res += temp.ToString();
        }
        int i = 0;
        while(i < k){
            var total = 0;
            foreach(var c in res)
                total += c - '0';
            res = total.ToString();
            i++;
        }
        int rs = 0;
        foreach(var c in res){
            rs *= 10;
            rs += c - '0';
        }
        return rs;
    }
}
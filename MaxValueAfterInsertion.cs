//https://leetcode.com/problems/maximum-value-after-insertion/

public class Solution {
    public string MaxValue(string n, int x) {

        for (int i = 0; i < n.Length; i++)
        {
            if(n[i] == '-') continue;
            if (n[0] == '-' && int.Parse(n[i].ToString()) > x) {
                return n.Substring(0, i) + x + n.Substring(i);
            }
            else if (n[0] != '-' && int.Parse(n[i].ToString()) < x){
                return n.Substring(0, i) + x + n.Substring(i);
            }
        }
        return n + x;
    }
}
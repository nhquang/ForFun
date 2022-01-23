//https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/

public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        var rs = new List<string>();
        int temp = 1;
        string curr = "";
        for(int i = 0; i < s.Length; i++){
            temp++;
            curr += s[i];
            if(temp > k){
                temp = 1;
                rs.Add(curr);
                curr = "";
            }
        }
        if(temp <= k && temp != 1){
            for(int i = 0; i <= k - temp; i++)
                curr += fill;
            rs.Add(curr);
        }
        return  rs.ToArray();
    }
}
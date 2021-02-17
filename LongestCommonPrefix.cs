//https://leetcode.com/problems/longest-common-prefix/


public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int j = 1;
        if(strs.Length == 0 || strs.Length == 1) return strs.Length == 0 ? "" : strs[0];
        foreach(var item in strs) if(item == string.Empty) return "";
        string curr = strs[0].Substring(0,j);;
        string rslt ="";
        for(int i = 0; i < strs.Length; i++){
            string temp = "";
            if(j <= strs[i].Length){
                if (i == 0) curr = strs[i].Substring(0,j);
                temp = strs[i].Substring(0,j);
            }
            else break;
            if(temp != curr) break;
            if(i == strs.Length - 1 && temp == curr){
                 rslt = curr;
                 i = -1; j++;
            }
        }
        return rslt;
    }
}
//https://leetcode.com/problems/longest-common-prefix/


public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int j = 0;
        char temp = '\0';
        bool emp = false;
        string rslt = "";
        if (strs.Length == 1) return strs[0];
        for(int i = 0; i < strs.Length; i++){
            if (i == 0)
            {
                if (strs[i] == "") emp = true;
                else{
                    if (j >= strs[i].Length) break;
                    temp = strs[i][j];
                }
            }
            else
            {
                if (strs[i] == "") { if (!emp) break; }
                else if (j < strs[i].Length && strs[i][j] != temp) break;
                else if (j >= strs[i].Length) break;
                if (i == strs.Length - 1)
                {
                    if (strs[i] == "")
                        break;
                    else if (j < strs[i].Length && strs[i][j] != temp) break;
                    else if (j >= strs[i].Length) break;
                    if (!emp) rslt += temp;
                    emp = false;
                    j++; i = -1;
                }
            }
        }
        return rslt;
    }
}
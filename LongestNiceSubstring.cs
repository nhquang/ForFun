//https://leetcode.com/problems/longest-nice-substring/


public class Solution {
    public string LongestNiceSubstring(string s) {
        string rslt = "";
        int count = 2;
        while(count <= s.Length){
            for(int j = 0; j + count <= s.Length; j++){
                var temp = s.Substring(j, count); 
                if(isNice(temp) && temp.Length > rslt.Length) rslt = temp;
            }
            count++;
        }
        return rslt;
    }
    bool isNice(string s){
        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsLower(s[i]) && !s.Contains(Char.ToUpper(s[i])))
                return false;
            else if (Char.IsUpper(s[i]) && !s.Contains(Char.ToLower(s[i])))
                return false;
                
        }
        return true;
    }
}
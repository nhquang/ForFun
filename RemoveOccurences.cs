//https://leetcode.com/problems/remove-all-occurrences-of-a-substring/


public class Solution {
    public string RemoveOccurrences(string s, string part) {
        for(int i = 0; i + part.Length <= s.Length; i++){
            for(int j = i; j + part.Length <= s.Length; j += part.Length){
                var temp = s.Substring(j, part.Length);
                if(temp == part){
                    if(j == 0) s = s.Substring(j + part.Length, s.Length - part.Length);
                    else {
                        s = s.Substring(0, j) + s.Substring(j + part.Length, s.Length - (j + part.Length));
                    }
                    i = -1; break;
                }
            }
        }
        return s;
    }
}
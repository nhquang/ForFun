//https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/


public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        var dict = new Dictionary<char, char>();
        int count = 0;
        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != s2[i]){
                if(dict.ContainsKey(s2[i])){
                    if(dict[s2[i]] != s1[i]) return false;
                    else{
                        dict.Remove(s2[i]);
                        continue;
                    }
                }
                else{
                    count++;
                    if(count > 1) return false;
                    else dict.Add(s1[i], s2[i]);
                }
            }
        }
        if(dict.Count > 0) return false;
        return true;
    }
}
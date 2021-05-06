//https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/

public class Solution {
    public int MinSteps(string s, string t) {
        var dict1 = new Dictionary<char,int>();
        var dict2 = new Dictionary<char,int>();
        for(int i = 0; i < s.Length; i++){
            if(dict1.ContainsKey(s[i])) dict1[s[i]]++;
            else dict1.Add(s[i], 1);
            if(dict2.ContainsKey(t[i])) dict2[t[i]]++;
            else dict2.Add(t[i], 1);
        }
        int rs = 0;
        foreach(var item in dict1){
            if(dict2.ContainsKey(item.Key)){
                if(item.Value > dict2[item.Key]) rs += item.Value - dict2[item.Key];
            }
            else rs += item.Value;
        }
        return rs;
    }
}
//https://leetcode.com/problems/find-and-replace-pattern/

public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        var result = new List<string>();
        foreach(var item in words){
            var dict = new Dictionary<char,char>();
            int i = 0;
            foreach(var l in item){
                if(dict.ContainsKey(l)) { if(dict[l] != pattern[i]) break; }
                else if (dict.ContainsValue(pattern[i])) break;
                else dict.Add(l, pattern[i]);
                i++;
            }
            if(i == pattern.Length) result.Add(item);
        }
        return result;
    }
}
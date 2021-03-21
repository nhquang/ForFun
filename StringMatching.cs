//https://leetcode.com/problems/string-matching-in-an-array/

public class Solution {
    public IList<string> StringMatching(string[] words) {
        var rslt = new HashSet<string>();
        for(int i = 0; i < words.Length; i++){
            for(int j = 0; j < words.Length; j++){
                if(i != j && words[i].Length > words[j].Length){
                    if(words[i].Contains(words[j]) && !rslt.Contains(words[j])) rslt.Add(words[j]);
                }
            }
        }
        return rslt.ToList();
    }
}
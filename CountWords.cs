//https://leetcode.com/problems/count-common-words-with-one-occurrence/

public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int>();
        for(int i = 0; i < words1.Length; i++){
            if(dict1.ContainsKey(words1[i])) dict1[words1[i]]++;
            else dict1.Add(words1[i], 1);
        }
        for(int i = 0; i < words2.Length; i++){
            if(dict2.ContainsKey(words2[i])) dict2[words2[i]]++;
            else dict2.Add(words2[i], 1);
        }
        int rs = 0;
        foreach(var item in dict1){
            if(item.Value == 1 && dict2.ContainsKey(item.Key) && dict2[item.Key] == 1)
                rs++;
        }
        return rs;
    }
}
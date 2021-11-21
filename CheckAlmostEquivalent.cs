//https://leetcode.com/problems/check-whether-two-strings-are-almost-equivalent/

public class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();
        for(int i = 0; i < word1.Length; i++){
            if(dict1.ContainsKey(word1[i])) dict1[word1[i]]++;
            else dict1.Add(word1[i], 1);
            if(dict2.ContainsKey(word2[i])) dict2[word2[i]]++;
            else dict2.Add(word2[i], 1);
        }
        foreach(var item in dict1){
            if(dict2.ContainsKey(item.Key)){
                if(Math.Abs(item.Value - dict2[item.Key]) > 3)
                    return false;
            }
            else if (item.Value > 3)
                return false;
        }
        foreach(var item in dict2){
            if(!dict1.ContainsKey(item.Key) && item.Value > 3)
                return false;
        }
        
        return true;
    }
}


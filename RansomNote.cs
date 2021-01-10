//https://leetcode.com/problems/ransom-note/


public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dict1 = new Dictionary<int, int>();
        var dict2 = new Dictionary<int,int>();
        for(int i = 0; i < ransomNote.Length || i < magazine.Length; i++){
            if(i < ransomNote.Length){
                if(dict1.ContainsKey(ransomNote[i])) dict1[ransomNote[i]]++;
                else dict1.Add(ransomNote[i], 1);
            }
            if(i < magazine.Length){
                if(dict2.ContainsKey(magazine[i])) dict2[magazine[i]]++;
                else dict2.Add(magazine[i], 1);
            }
        }
        foreach(var item in dict1){
            if(!dict2.ContainsKey(item.Key) || dict2[item.Key] < item.Value){
                return false;
            }
        }
        return true;
    }
}
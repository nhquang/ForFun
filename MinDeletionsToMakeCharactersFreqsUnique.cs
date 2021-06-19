//https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/

public class Solution {
    public int MinDeletions(string s) {
        var dict = new Dictionary<char,int>();
        foreach(var item in s){
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        var sorted = dict.Values.ToArray();
        Array.Sort(sorted);
        Array.Reverse(sorted);
        int rs = 0;
        for(int i = 0; i < sorted.Length && sorted[i] != 0; i++){
            for(int j = i + 1; j < sorted.Length && sorted[j] == sorted[i]; j++){
                sorted[j]--; rs++;
            }
        }
        return rs;
    }
}
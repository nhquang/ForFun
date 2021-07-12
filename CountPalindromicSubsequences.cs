//https://leetcode.com/problems/unique-length-3-palindromic-subsequences/

public class Solution {
    public int CountPalindromicSubsequence(string s) {
        int rs = 0;
        var dict = new Dictionary<char, int[]>();
        for(int i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i])) dict.Add(s[i], new int[2]{i, -1});
            else dict[s[i]][1] = i;
        }
        foreach(var item in dict){
            if(item.Value[1] != -1){
                int i = item.Value[0] + 1, j = item.Value[1];
                var set = new HashSet<char>();
                while(i < j)
                    set.Add(s[i++]);
                rs += set.Count;
            }
        }
        return rs;
    }
}
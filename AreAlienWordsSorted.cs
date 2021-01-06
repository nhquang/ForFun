//https://leetcode.com/problems/verifying-an-alien-dictionary/


public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var dict = new Dictionary<char, int>();
        for(int i = 0; i < order.Length; i++)
            if (!dict.ContainsKey(order[i])) dict.Add(order[i], i);
        for (int i = 1; i < words.Length; i++)
        {
            int j;
            for (j = 0; j < words[i-1].Length && j < words[i].Length; j++)
            {
                if (dict[words[i - 1][j]] > dict[words[i][j]]) return false;
                else if (dict[words[i - 1][j]] < dict[words[i][j]]) break;
            }
            if(j == words[i-1].Length || j == words[i].Length)
                if (words[i - 1].Length > words[i].Length) return false;
        }
        return true;
    }
}
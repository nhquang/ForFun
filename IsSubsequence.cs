//https://leetcode.com/problems/is-subsequence/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        var dict = new Dictionary<char, List<int>>();

        for (int i = 0; i < t.Length; i++)
        {
            if (dict.ContainsKey(t[i])) dict[t[i]].Add(i);
            else dict.Add(t[i], new List<int>() { i });
        }
        int prev = -1;
        foreach (var item in s)
        {
            if (!dict.ContainsKey(item)) return false;
            else
            {
                for(int i = 0; i < dict[item].Count; i++)
                {
                    if(dict[item][i] > prev)
                    {
                        prev = dict[item][i];
                        dict[item].RemoveRange(0, i + 1);
                        if (dict[item].Count == 0) dict.Remove(item);
                        break;
                    }
                    if (i == dict[item].Count - 1) return false;
                }
            }
        }
        return true;
    }
	//O(n) where n is t.Length, )(1) space
	public bool IsSubsequence(string s, string t) {
        int sIdx = 0;
        for(int tIdx = 0; tIdx < t.Length; tIdx++){
            if(sIdx < s.Length && s[sIdx] == t[tIdx]) sIdx++;
        }
        return sIdx == s.Length;
    }
}
//https://leetcode.com/problems/increasing-decreasing-string/

public class Solution {
    public string SortString(string s) {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i])) dict.Add(s[i], 1);
            else dict[s[i]]++;
        }
        var sorted = dict.Keys.ToArray();
        Array.Sort(sorted);
        var sb = "";
        while(dict.Count > 0)
        {
            for(int i = 0; i < sorted.Length; i++)
            {
                if (dict.ContainsKey(sorted[i]))
                {
                    sb += sorted[i];
                    dict[sorted[i]]--;
                    if (dict[sorted[i]] == 0) dict.Remove(sorted[i]);
                }
            }
            for(int i = sorted.Length - 1; i >= 0; i--)
            {
                if (dict.ContainsKey(sorted[i]))
                {
                    sb += sorted[i];
                    dict[sorted[i]]--;
                    if (dict[sorted[i]] == 0) dict.Remove(sorted[i]);
                }
            }
        }
        return sb;
        
    }
}
//https://leetcode.com/problems/largest-substring-between-two-equal-characters/


public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int i = 0, j = s.Length - 1, max = -1;
        var dict = new Dictionary<char, int>();
        while (j > i)
        {
            if (!dict.ContainsKey(s[i])) dict.Add(s[i], i);
            else if (dict[s[i]] > s.Length / 2) 
                max = Math.Max(dict[s[i]] - i - 1, max);
            if (!dict.ContainsKey(s[j])) dict.Add(s[j], j);
            else if (dict[s[j]] < s.Length / 2)
                max = Math.Max(j - dict[s[j]] - 1, max);

            i++; j--;
        }
        return max;
    }
}
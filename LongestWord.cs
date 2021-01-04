//https://leetcode.com/problems/longest-word-in-dictionary/


public class Solution {
    public string LongestWord(string[] words) {
        var set = new HashSet<string>();
        for (int i = 0; i < words.Length; i++)
            set.Add(words[i]);
        words = words.OrderBy(i => i.Length).ThenBy(i => i).ToArray();
        var rslt = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            var temp = "";
            for (int j = 0; j < words[i].Length; j++)
            {
                temp += words[i][j];
                if (!set.Contains(temp)) break;
            }
            if (set.Contains(temp)) rslt = temp;
            if (i - 1 < 0 || (rslt != "" && words[i - 1].Length < rslt.Length)) return rslt;
        }
        return rslt;
    }
}
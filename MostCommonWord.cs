//https://leetcode.com/problems/most-common-word/



public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var copy = "";
        foreach (var item in paragraph)
        {
            if (Char.IsWhiteSpace(item) || Char.IsLetter(item))
                copy += Char.ToLower(item);
            else copy += " ";
        }
        var words = copy.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var dict = new Dictionary<string, int>();
        foreach(var item in words)
        {
            if (dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        var sorted = dict.OrderByDescending(i => i.Value).Select(i => i.Key).ToArray();
        var bannedSet = new HashSet<string>();

        for(int i = 0; i < banned.Length; i++)
            bannedSet.Add(banned[i]);

        foreach (var item in sorted)
            if (!bannedSet.Contains(item)) return item;
        return "";
    }
}
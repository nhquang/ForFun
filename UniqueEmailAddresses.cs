//https://leetcode.com/problems/unique-email-addresses/

public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var set = new HashSet<string>();
        for (int i = 0; i < emails.Length; i++)
        {
            var first = emails[i].Substring(0, emails[i].IndexOf('@'));
            int temp = first.IndexOf('+');
            if(temp >= 0) first = first.Substring(0, temp);
            first = first.Replace(".", "");
            var second = emails[i].Substring(emails[i].IndexOf('@'));
            if (!set.Contains(first+second)) set.Add(first+second);
        }
        return set.Count;
    }
}
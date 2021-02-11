//https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/

public class Solution {
    public string ModifyString(string s) {
        if(s.Length == 1) return s[0] == '?' ? 'a'.ToString() : s;
        var chars = s.ToCharArray();
        char[] alphas = new char[26];
        int count = 97;
        for(int i = 0; i < 26; i++) { alphas[i] = Convert.ToChar(count); count++;}
        for(int i = 0; i < chars.Length; i++){
            if (chars[i] == '?')
                {
                    for (int j = 0; j < alphas.Length; j++)
                    {
                        if ((i - 1 >= 0 && chars[i - 1] != alphas[j]) && (i + 1 < chars.Length && chars[i + 1] != alphas[j])) { chars[i] = alphas[j]; break; }
                        else if (i - 1 < 0 && chars[i + 1] != alphas[j]) { chars[i] = alphas[j]; break; }
                        else if (i + 1 >= chars.Length && chars[i - 1] != alphas[j]) { chars[i] = alphas[j]; break; }
                    }
                }
        }
        return new string(chars);
    }
}
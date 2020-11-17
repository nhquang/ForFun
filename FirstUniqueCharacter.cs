//https://leetcode.com/problems/first-unique-character-in-a-string/



// O(2n)
public class Solution {
    public  int FirstUniqChar(string s)
    {
        var occur = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (occur.ContainsKey(s[i])) occur[s[i]]++;
            else occur.Add(s[i], 1);
        }
        for (int i = 0; i < s.Length; i++){
            if(occur[s[i]] == 1) return i;
        }
        return -1;
    }
}


// slightly faster
public class Solution {
    public  int FirstUniqChar(string s)
    {
        if(s.Length == 1) return 0;
        for(int i = 0; i < s.Length; i++){
            for(int j = 0; j < s.Length; j++){
                if(i == s.Length - 1 && j == s.Length - 1) return i;
                if(i == j) continue;
                if(s[i] == s[j]) break;
                
                if(j == s.Length - 1 && s[i] != s[j]) return i;
            }
        }
        return -1;
    }
}


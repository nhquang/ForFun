	//https://leetcode.com/problems/valid-palindrome/


	public bool IsPalindrome(string s) {
        s = s.Replace(" ", "").ToLower();
        int i = 0, j = s.Length - 1;
        while(j > i)
        {
            if (!Char.IsLetterOrDigit(s[i])) j++;
            else if (!Char.IsLetterOrDigit(s[j])) i--;
            else if (s[i] != s[j]) return false;
            i++; j--;
        }
        
        return true;
    }
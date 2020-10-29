	//https://leetcode.com/problems/valid-palindrome-ii/
	
	
	
	
	public bool ValidPalindrome(string s) {
        int j = s.Length - 1, i = 0;

        while (j >= i)
        {
            if(s[i] != s[j])
            {
                var a = IsPalindrome(s.Remove(i, 1));
                var b = IsPalindrome(s.Remove(j, 1));
                if (a || b) return true;
                else return false;
            }
            i++; j--;
        }
            
        return true;
    }
    private static bool IsPalindrome(string subString)
    {
        int i = 0, j = subString.Length - 1;
        while(j >= i)
        {
            if (subString[i] != subString[j]) return false;
            i++; j--;
        }
        return true;
    }
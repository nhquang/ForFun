	//https://leetcode.com/problems/longest-palindrome/


	public int LongestPalindrome(string s) {
        var chars = new Dictionary<char,int>();
        foreach(var item in s){
            if(chars.ContainsKey(item)) chars[item]++;
            else chars.Add(item, 1);
        }
        int length = 0;
        bool oddExist = false;
        foreach(var item in chars){
            if(!oddExist && item.Value % 2 != 0){
                if(item.Value == 1) length++;
                else length += item.Value;
                oddExist = true;
            }
            else length += item.Value % 2 == 0 ? item.Value : item.Value - 1;
        }
        return length;
    }
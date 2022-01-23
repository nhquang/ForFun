//https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/
public class Solution {
    public bool CheckString(string s) {
        bool b = false;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'b') b = true;
            if(s[i] == 'a' && b)
                return false;
        }
        return true;
    }
}
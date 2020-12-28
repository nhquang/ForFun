//https://leetcode.com/problems/repeated-substring-pattern/

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int temp = s.Length / 2;
        while(temp >= 1){
            if(s.Length % temp == 0){
                string t = s.Substring(0, temp);
                string t1 = "";
                for(int i = 0; i < s.Length / temp; i++){
                    t1 += t;
                }
                if(t1 == s) return true;
            }
            temp--;
        }
        return false;
    }
}
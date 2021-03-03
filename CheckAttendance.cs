//https://leetcode.com/problems/student-attendance-record-i/

public class Solution {
    public bool CheckRecord(string s) {
        int As = 0, Ls = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'A') {
                As++;
                if(As > 1) return false;
                Ls = 0;
            }
            else if(s[i] == 'L'){
                Ls++;
                if(Ls > 2) return false;
            }
            else { Ls = 0; }
        }
        return true;
    }
}
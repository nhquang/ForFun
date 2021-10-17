//https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/

public class Solution {
    public bool AreNumbersAscending(string s) {
        var arr = s.Split(' ');
        var prev = -1;
        for(int i = 0; i < arr.Length; i++){
            if(TryParse(arr[i], out int num)){
                if(num <= prev)
                    return false;
                prev = num;
            }
        }
        return true;
    }
    bool TryParse(string s, out int rs){
        var arr = s.ToCharArray();
        rs = 0;
        for(int i = 0; i < s.Length; i++){
            if(Char.IsDigit(s[i]))
                rs = (rs + s[i] - '0') * 10;
            else
                return false;
        }
        rs /= 10;
        return true;
    }
}
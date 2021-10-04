//https://leetcode.com/problems/minimum-moves-to-convert-string/


public class Solution {
    public int MinimumMoves(string s) {
        var rs = s.ToCharArray();
        var count = 0;
        for(int i = 0; i < rs.Length; i++){
            if(rs[i] == 'X'){
                rs[i++] = 'O';
                if(i < rs.Length) rs[i++] = 'O';
                if(i < rs.Length) rs[i] = 'O';
                count++;
            }
        }
        return count;
    }
}
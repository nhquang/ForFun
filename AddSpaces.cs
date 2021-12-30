//https://leetcode.com/problems/adding-spaces-to-a-string/

public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        var rs = new char[s.Length + spaces.Length];
        int rsIdx = 0, spaceIdx = 0;
        for(int i = 0; i < s.Length; i++){
            if(spaceIdx < spaces.Length && i == spaces[spaceIdx]){
                rs[rsIdx++] = ' ';
                spaceIdx++;
            }
            rs[rsIdx++] = s[i];
        }
        return new string(rs);
    }
}
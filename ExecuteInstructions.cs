//https://leetcode.com/problems/execution-of-all-suffix-instructions-staying-in-a-grid/

public class Solution {
    public int[] ExecuteInstructions(int n, int[] startPos, string s) {
        var rs = new List<int>();
        for(int i = 0; i < s.Length; i++){
            int moves = 0;
            int row = startPos[0], col = startPos[1];
            for(int j = i; j < s.Length; j++){
                switch(s[j]){
                    case 'U':
                        row--;
                        break;
                    case 'D':
                        row++;
                        break;
                    case 'L':
                        col--;
                        break;
                    default:
                        col++;
                        break;
                }
                if(row > n - 1 || row < 0 || col > n - 1 || col < 0)
                    break;
                moves++;
            }
            rs.Add(moves);
        }
        return rs.ToArray();
    }
}
//https://leetcode.com/problems/lucky-numbers-in-a-matrix/

public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        var rs= new List<int>();
        for(int i = 0; i < matrix.Length; i++){
            int minIdx = 0;
            for(int j = 0; j < matrix[i].Length; j++){
                if(matrix[i][j] < matrix[i][minIdx]) minIdx = j;
            }
            bool max = true;
            for(int j = 0; j < matrix.Length; j++){
                if(matrix[j][minIdx] > matrix[i][minIdx]) max = false;
            }
            if(max) rs.Add(matrix[i][minIdx]);
        }
        return rs;
    }
}
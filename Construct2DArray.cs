//https://leetcode.com/problems/convert-1d-array-into-2d-array/

public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(original.Length % n == 0 && original.Length / n == m){
            var rs = new List<int[]>();
            int idx = 0;
            for(int i = 0; i < m; i++){
                int[] temp = new int[n];
                for(int j = 0; j < n; j++)
                    temp[j] = original[idx++];
                rs.Add(temp);
            }
            return rs.ToArray();
        }
        return new int[][]{};
    }
}
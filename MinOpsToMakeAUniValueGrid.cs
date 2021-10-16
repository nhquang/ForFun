//https://leetcode.com/problems/minimum-operations-to-make-a-uni-value-grid/

public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int total = 0, noOfNum = 0, rs = 0, idx = 0;
        if(grid.Length == 1 && grid[0].Length == 1)
            return 0;
        var arr = new int[grid.Length * grid[0].Length];
        int remainder = grid[0][0] % x;
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                if(grid[i][j] % x != remainder)
                    return -1;
                arr[idx++] = grid[i][j];
            }
        }
        Array.Sort(arr);
        int med = arr[arr.Length / 2];
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                int temp = Math.Abs(med - grid[i][j]);
                rs += temp / x;
            }
        }
        return rs;
    }
}
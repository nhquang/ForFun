//https://leetcode.com/problems/island-perimeter/

public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int sum = 0;
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                if(grid[i][j] == 1){
                    int temp = 4;
                    if(j - 1 >= 0 && grid[i][j-1] == 1) temp--;
                    if(i - 1 >= 0 && grid[i - 1][j] == 1) temp--;
                    if(j + 1 < grid[i].Length && grid[i][j + 1] == 1) temp--;
                    if(i + 1 < grid.Length && grid[i+1][j] == 1) temp--;
                    sum += temp;
                }
            }
        }
        return sum;
    }
}
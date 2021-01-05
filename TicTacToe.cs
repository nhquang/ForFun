//https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/

public class Solution {
    public string Tictactoe(int[][] moves) {
        var grid = new List<int[]>() { new int[3], new int[3], new int[3] }.ToArray();
            for (int i = 0; i < moves.Length; i++)
            {
                int temp = 2;
                if (i % 2 == 0) temp = 1;
                grid[moves[i][0]][moves[i][1]] = temp;
            }
            for(int i = 0; i < 3; i++)
            {
                if(grid[i][0] != 0 && (grid[i][0] == grid[i][1] && grid[i][1] == grid[i][2]))
                {
                    if (grid[i][0] == 1) return "A";
                    else return "B";
                }
                if (grid[0][i] != 0 && (grid[0][i] == grid[1][i] && grid[2][i] == grid[1][i]))
                {
                    if (grid[0][i] == 1) return "A";
                    else return "B";
                }
                
            }
            if (grid[0][0] != 0 && (grid[0][0] == grid[1][1] && grid[0][0] == grid[2][2]))
            {
                if (grid[0][0] == 1) return "A";
                else return "B";
            }
            if (grid[0][2] != 0 && (grid[0][2] == grid[1][1] && grid[0][2] == grid[2][0]))
            {
                if (grid[0][2] == 1) return "A";
                else return "B";
            }
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 0) return "Pending";
            }

            return "Draw";
    }
}
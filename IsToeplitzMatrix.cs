//https://leetcode.com/problems/toeplitz-matrix/

public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
            for(int j = 0; j < matrix[i].Length; j++)
                if (i + 1 < matrix.Length && j + 1 < matrix[i + 1].Length)
                    if (matrix[i][j] != matrix[i + 1][j + 1]) return false;
        return true;
    }
}
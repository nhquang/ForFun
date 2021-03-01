
//https://leetcode.com/problems/flipping-an-image/
public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        for(int i = 0; i < A.Length; i++)
        {
            int tail = A[i].Length - 1, head = 0;
            while (tail > head)
            {
                int temp = A[i][tail];
                A[i][tail] = A[i][head];
                A[i][head] = temp;
                tail--;head++;
            }
                    
            for (int j = 0; j < A[i].Length; j++)
            {
                if (A[i][j] == 0) A[i][j] = 1;
                else A[i][j] = 0;
            }
        }
        return A;
    }
}
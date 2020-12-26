//https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/


public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var temp = new Dictionary<int,int>();
        for(int i = 0; i < mat.Length; i++){
            int soldiers = 0;
            for(int j = 0; j < mat[i].Length; j++){
                if(mat[i][j] == 1) soldiers++;
                else break;
            }
            temp.Add(i,soldiers);
        }
        var temp2 = temp.OrderBy(i => i.Value).ThenBy(u => u.Key).Select(e => e.Key).ToArray();
        var rslt = new int[k];
        
        for(int h = 0; h < k; h++)
            rslt[h] = temp2[h];
        
        return rslt;
    }
}
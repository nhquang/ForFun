//https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/


public class Solution {
	//Without LINQ
	public int[] KWeakestRows(int[][] mat, int k) {
        var sorted = new SortedDictionary<int, SortedSet<int>>();
        for(int i = 0; i < mat.Length; i++){
            int sol = 0;
            for(int j = 0; j < mat[i].Length; j++){
                if(mat[i][j] == 1) sol++;
            }
            if(sorted.ContainsKey(sol)) sorted[sol].Add(i);
            else {
                var set = new SortedSet<int>();
                set.Add(i);
                sorted.Add(sol, set);
            }
        }
        int counter = 0;
        var rs = new int[k];
        foreach(var item in sorted){
            foreach(var val in item.Value){
                if(counter >= k) break;
                rs[counter++] = val;
            }
        }
        return rs;
    }
	
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
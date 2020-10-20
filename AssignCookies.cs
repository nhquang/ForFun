	//https://leetcode.com/problems/assign-cookies/
	
	public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int count = 0;
        int j = 0;
        for(int i = 0; i < g.Length && j < s.Length; i++){
            if(g[i] <= s[j]) count++;
            else i--;
            j++;
        }
        
        return count;
    }
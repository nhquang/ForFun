//https://leetcode.com/problems/count-square-sum-triples/


public class Solution {
    public int CountTriples(int n) {
        int rs = 0;
        for(int i = 1; i <= n; i++){
            for(int j = i + 1; j <= n; j++){
                int temp = (int)Math.Sqrt(i * i + j * j);
                if(temp * temp == i * i + j * j && temp <= n) rs++;
                else if (temp > n) break;
            }
        }
        return rs * 2;
    }
}
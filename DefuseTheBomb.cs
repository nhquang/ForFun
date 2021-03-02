//https://leetcode.com/problems/defuse-the-bomb/

public class Solution {
    public int[] Decrypt(int[] code, int k) {
        var rslt = new int[code.Length];
        for(int i = 0; i < code.Length; i++){
            int j = i+1, h = i - 1, count = 0, sum = 0;
            while(k >= 0 && count < k){
                if(j > code.Length - 1) j = 0;
                sum += code[j];
                j++;count++;
            }
            while(k < 0 && count < Math.Abs(k)){
                if(h < 0) h = code.Length - 1;
                sum += code[h];
                h--;count++;
            }
            rslt[i] = sum;
        }
        return rslt;
    }
}
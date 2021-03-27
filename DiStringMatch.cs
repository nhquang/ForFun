
//https://leetcode.com/problems/di-string-match/

public class Solution {
    public int[] DiStringMatch(string S) {
        var result = new int[S.Length + 1];
        int low = 0, high = S.Length, j = 0;
        for(int i = 0; i < S.Length ; i++){
            if(S[i] == 'I'){
                result[j] = low;
                low++;
            }
            else{
                result[j] = high;
                high--;
            }
            j++;
        }
        if(S[S.Length - 1] == 'D') result[j] = high;
        else result[j] = low;
        return result;
    }
}
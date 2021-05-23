//https://leetcode.com/problems/longer-contiguous-segments-of-ones-than-zeros/


public class Solution {
    public bool CheckZeroOnes(string s) {
        int zeros = 0, ones = 0, maxZeros = 0, maxOnes = 0;
        bool prevZ = false, prevO = false;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '1'){
                maxOnes = Math.Max(maxOnes, ++ones);
                if(!prevO){
                    prevZ = false; prevO = true;
                    zeros = 0;
                }
            }
            else{
                maxZeros = Math.Max(maxZeros, ++zeros);
                if(!prevZ){
                    prevO = false; prevZ = true; 
                    ones = 0;
                }
            }
        }
        
        return maxOnes > maxZeros;
    }
}
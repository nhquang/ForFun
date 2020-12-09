//https://leetcode.com/problems/check-array-formation-through-concatenation/


public class Solution {
    public bool CanFormArray(int[] arr, int[][] pieces) {
        int count = 0;
        for(int i = 0; i < arr.Length; i++){
            
            for(int j = 0; j < pieces.Length; j++){
                if(pieces[j][0] == arr[i]){
                    
                    for(int h = 0; h < pieces[j].Length && i < arr.Length; h++){
                        if(pieces[j][h] != arr[i]) return false;
                        else if(h == pieces[j].Length - 1 && i == arr.Length - 1) return true;
                        i++;
                        count++;
                    }
                    i--;
                    break;
                }
            }
            
        }
        if (count != arr.Length) return false;
        return true;
    }
}
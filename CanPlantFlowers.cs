//https://leetcode.com/problems/can-place-flowers/


public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        bool planted = false;
        for(int i = 0; i < flowerbed.Length; i++){
            if(flowerbed[i] == 1) planted = true;
            else{
                if(planted) planted = false;
                else{
                    if(flowerbed.Length - 1 == i) n--;
                    else{
                        if(flowerbed[i+1] == 0){
                            n--;
                            planted = true;
                        } 
                    }
                }
            }
        }
        return n > 0 ? false : true;
    }
}
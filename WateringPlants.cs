//https://leetcode.com/problems/watering-plants/

public class Solution {
    public int WateringPlants(int[] plants, int capacity) {
        int rs = 0, river = -1, bucket = capacity;
        for(int i = 0; i < plants.Length; i++){
            if(bucket >= plants[i]){
                bucket -= plants[i];
                rs++;
            }
            else {
                rs += (i - river - 1) + (i - river);
                bucket = capacity - plants[i];
            }
        }
        return rs;
    }
}
//https://leetcode.com/problems/water-bottles/


public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int sum = numBottles;
        while(numBottles >= numExchange){
            int temp = numBottles / numExchange;
            sum += temp;
            numBottles = temp + (numBottles - (temp * numExchange));
        }
        return sum;
    }
}
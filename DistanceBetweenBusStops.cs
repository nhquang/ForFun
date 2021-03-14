//https://leetcode.com/problems/distance-between-bus-stops/

public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        int forward = 0, backward = 0;
            
        for(int i = start; i != destination; i++)
        {
            if (i == distance.Length) i = -1;
            else forward += distance[i];
        }
        for(int i = start - 1; i != destination; i--)
        {
            if (i == -1) i = distance.Length;
            else backward += distance[i];
        }
        backward += distance[destination];
        return Math.Min(forward, backward);
    }
}
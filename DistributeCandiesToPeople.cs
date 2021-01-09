//https://leetcode.com/problems/distribute-candies-to-people/


public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int n = 1;
        var rslt = new int[num_people];
        while (candies > 0)
        {
            for (int i = 0; i < rslt.Length; i++)
            {
                if (n <= candies) rslt[i] += n;
                else
                {
                    rslt[i] += candies;
                    candies -= candies;
                    break;
                }
                candies -= n;
                n++;
            }
        }
        return rslt;
    }
}
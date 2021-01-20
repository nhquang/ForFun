//https://leetcode.com/problems/find-lucky-integer-in-an-array/

public class Solution {
    public int FindLucky(int[] arr) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < arr.Length; i++){
            if(dict.ContainsKey(arr[i])) dict[arr[i]]++;
            else dict.Add(arr[i], 1);
        }
        int max = -1;
        foreach(var item in dict){
            if(item.Key == item.Value) max = Math.Max(item.Key, max);
        }
        return max;
    }
}
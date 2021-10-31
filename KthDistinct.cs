//https://leetcode.com/problems/kth-distinct-string-in-an-array/

public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var dict = new Dictionary<string, int>();
        for(int i = 0; i < arr.Length; i++){
            if(dict.ContainsKey(arr[i])) dict[arr[i]]++;
            else dict.Add(arr[i], 1);
        }
        int idx = 0;
        foreach(var item in dict){
            if(item.Value == 1){
                if(++idx == k)
                    return item.Key;
            }
        }
        return string.Empty;
    }
}
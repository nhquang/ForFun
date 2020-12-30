//https://leetcode.com/problems/reduce-array-size-to-the-half/



public class Solution {
    public int MinSetSize(int[] arr) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < arr.Length; i++){
            if(dict.ContainsKey(arr[i])) dict[arr[i]]++;
            else dict.Add(arr[i], 1);
            
        }
        var sorted = dict.OrderBy(i => i.Value).Select(i => i.Key).ToArray();
        int count = 0, rslt = 0;
        for(int i = sorted.Length - 1; i >= 0; i--){
            rslt++;
            count += dict[sorted[i]];
            if(count >= (arr.Length / 2)) return rslt;
        }
        return 0;
    }
}
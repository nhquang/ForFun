//https://leetcode.com/problems/unique-number-of-occurrences/

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < arr.Length; i++){
            if(dict.ContainsKey(arr[i])) dict[arr[i]]++;
            else dict.Add(arr[i], 1);
        }
        var set = new HashSet<int>();
        foreach(var item in dict){
            if(set.Contains(item.Value)) return false;
            set.Add(item.Value);
        }
        return true;
    }
}
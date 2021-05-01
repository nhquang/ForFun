//https://leetcode.com/problems/make-two-arrays-equal-by-reversing-sub-arrays/

public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        var dict = new Dictionary<int,int>();
        foreach(var item in target){
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        foreach(var item in arr){
            if(dict.ContainsKey(item)){
                dict[item]--;
                if(dict[item] == 0) dict.Remove(item);
            }
            else return false;
        }
        return dict.Count == 0 ? true : false;
    }
}
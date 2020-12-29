//https://leetcode.com/problems/intersection-of-two-arrays-ii/



public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var rslt = new List<int>();
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums1.Length; i++){
            if(!dict.ContainsKey(nums1[i])) dict.Add(nums1[i], 1);
            else dict[nums1[i]]++;
        }
        for(int j = 0; j < nums2.Length; j++){
            if(dict.ContainsKey(nums2[j])){
                rslt.Add(nums2[j]);
                if(dict[nums2[j]] == 1) dict.Remove(nums2[j]);
                else dict[nums2[j]]--;
            }
        }
        
        return rslt.ToArray();
    }
}
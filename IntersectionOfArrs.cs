//https://leetcode.com/problems/intersection-of-two-arrays/

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var rslt = new HashSet<int>();
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        for (int i = 0; i < nums1.Length || i < nums2.Length; i++){
            if(i < nums1.Length){
                set1.Add(nums1[i]);
                if(set2.Contains(nums1[i]))
                    rslt.Add(nums1[i]);
            }
            if(i < nums2.Length){
                set2.Add(nums2[i]);
                if(set1.Contains(nums2[i]))
                    rslt.Add(nums2[i]);
            }
        }
            

        return rslt.ToArray();
    }
}
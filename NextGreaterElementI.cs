//https://leetcode.com/problems/next-greater-element-i/

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var rs = new int[nums1.Length];
        for(int i = 0; i < nums1.Length; i++){
            for(int j = 0; j < nums2.Length; j++){
                if(nums1[i] == nums2[j]){
                    for(int h = j + 1; h < nums2.Length; h++){
                        if(nums2[h] > nums1[i]) { rs[i] = nums2[h]; break;}
                    }
                    if(rs[i] == 0) rs[i] = -1;
                    break;
                }
            }
        }
        return rs;
    }
}
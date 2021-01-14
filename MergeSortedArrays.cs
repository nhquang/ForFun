//https://leetcode.com/problems/merge-sorted-array/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int prev = int.MinValue;
        int j = 0, a = 0;
        if (nums1.Length == 1){
            if(nums2.Length > 0)nums1[0] = nums2[0];
            return;
        }
        for (j = 0; j < nums2.Length; j++)
        {
            bool check = false;
            for (int i = a; i < nums1.Length; i++)
            {
                if (nums1[i] == 0 && i >= m + j) nums1[i] = int.MaxValue;
                if (nums1[i] > nums2[j] || check)
                {
                    if (!check) { prev = nums2[j]; a = i; }
                        int temp = nums1[i];
                        nums1[i] = prev;
                        prev = temp;
                        check = true;
                    }
            }
        }
    }
}
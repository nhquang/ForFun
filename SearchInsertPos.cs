//https://leetcode.com/problems/search-insert-position/


public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }
    int BinarySearch(int[] arr, int l, int r, int target){
        if(r >= l){
            int mid = l + (r - l) / 2; 
            if(arr[mid] == target) return mid;
        
            else if(target > arr[mid]){
                return BinarySearch(arr, mid + 1, r, target);
            }
            return BinarySearch(arr, 0, mid - 1, target);
        }
        return l;
    }
}
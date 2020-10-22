	//https://leetcode.com/problems/binary-search/



	public int Search(int[] nums, int target) {
        return this.BinarySearch(nums, 0, nums.Length - 1, target);
    }
    public int BinarySearch(int[] arr, int l, int r, int target){
        if(r >= l){
            int mid = (l + r) / 2; 
            if(arr[mid] == target) return mid;
        
            else if(target > arr[mid]){
                return BinarySearch(arr, mid + 1, r, target);
            }
            return BinarySearch(arr, 0, mid - 1, target);
        }
        return -1;
    }
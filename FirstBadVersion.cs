//https://leetcode.com/problems/first-bad-version/





/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return BinarySearch(1 , n);
    }
    private int BinarySearch(int l, int r){
        if(r >= l){
            int mid = l + (r - l) / 2;
            if(IsBadVersion(mid) && !IsBadVersion(mid - 1)) return mid;
            else if(!IsBadVersion(mid)){
                return BinarySearch(mid + 1, r);
            }
            else if(IsBadVersion(mid) && IsBadVersion(mid - 1)){
                return BinarySearch(1, mid - 1);
            }
        }
        return -1;
    }
}
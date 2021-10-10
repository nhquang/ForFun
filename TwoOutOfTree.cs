//https://leetcode.com/problems/two-out-of-three/

public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        var hs2 = new HashSet<int>();
        foreach(var item in nums2){
            hs2.Add(item);
        }
        var hs3 = new HashSet<int>();
        foreach(var item in nums3){
            hs3.Add(item);
        }
        var rs = new HashSet<int>();
        foreach(var item in nums1){
            if(hs2.Contains(item))
                rs.Add(item);
            else if(hs3.Contains(item))
                rs.Add(item);
        }
        foreach(var item in hs2){
            if(hs3.Contains(item))
                rs.Add(item);
        }
        return rs.ToList();
    }
}
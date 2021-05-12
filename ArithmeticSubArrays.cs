//https://leetcode.com/problems/arithmetic-subarrays/
public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        var rs = new List<bool>();
        for(int i = 0; i < l.Length; i++){
            var temp = new int[r[i] - l[i] + 1];
            int count = 0;
            for(int j = l[i]; j <= r[i]; j++){
                temp[count] = nums[j];
                count++;
            }
            Array.Sort(temp);
            int range = temp[1] - temp[0];
            bool c = true;
            for(int j = 2; j < temp.Length; j++){
                if(temp[j] - temp[j - 1] != range) { c = false; break; }
            }
            rs.Add(c);
        }
        return rs;
    }
}
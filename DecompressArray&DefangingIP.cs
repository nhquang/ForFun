

public class Solution {
	//https://leetcode.com/problems/decompress-run-length-encoded-list/
    public int[] DecompressRLElist(int[] nums) {
        var result = new List<int>();
        for(int i = 0; i <= nums.Length - 2; i++){
            for(int j = 0; j < nums[i]; j++) result.Add(nums[i+1]);
            i++;
        }
        return result.ToArray();
    }
	
	//https://leetcode.com/problems/defanging-an-ip-address/
	public string DefangIPaddr(string address) {
        return address.Replace(".", "[.]");
    }
}
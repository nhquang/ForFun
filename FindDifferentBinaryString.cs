//https://leetcode.com/problems/find-unique-binary-string/


public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        var set = new HashSet<string>();
        foreach (var num in nums)
            set.Add(num);
        int a = 0;
        while (true)
        {
            var temp = Convert.ToString(a++, 2);
            temp = temp.PadLeft(nums.Length, '0');
            if (!set.Contains(temp))
                    return temp;
        }
        return string.Empty;
    }
}
//https://leetcode.com/problems/happy-number/




public class Solution {
    public bool IsHappy(int n) {
        var nums = new HashSet<int>();
        while(n != 1){
            var m = n;
            int temp = 0;
            while(m != 0){
                temp += ((m % 10) * (m % 10));
                m /= 10;
            }
            if(nums.Contains(temp)) return false;
            else nums.Add(temp);
            n = temp;
            temp = 0;
            
        }
        return true;
    }
}
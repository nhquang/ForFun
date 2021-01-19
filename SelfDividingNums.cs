//https://leetcode.com/problems/self-dividing-numbers/

public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var rslt = new List<int>();
        for (int i = left; i <= right; i++){
            int temp = i;
            while(temp != 0){
                if((temp % 10) == 0 || (i % (temp%10)) != 0 ) break;
                temp /= 10;
                if(temp == 0) rslt.Add(i);
            }
        }
        return rslt;
    }
}
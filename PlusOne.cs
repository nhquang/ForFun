//https://leetcode.com/problems/plus-one/


public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int carryOn = 0;
        var rslt = new List<int>();
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            int temp = 0;
            if (i == digits.Length - 1)
            {
                temp = digits[i] + 1;
                if (temp < 10)
                {
                    digits[i] = temp;
                    return digits;
                }
                else
                {
                    rslt.Add(temp - 10);
                    carryOn = 1;
                    continue;
                }
            }
            temp = digits[i] + carryOn;
            if(temp < 10)
            {
                rslt.Add(temp);
                carryOn = 0;
            }
            else
            {
                rslt.Add(temp - 10);
                carryOn = 1;
            }
                
        }
        if (carryOn > 0) rslt.Add(1);
        rslt.Reverse();
        return rslt.ToArray();
    }
}
//https://leetcode.com/problems/add-to-array-form-of-integer/


public class Solution {
    public IList<int> AddToArrayForm(int[] A, int k) {
        var klist = new List<int>();
        var rslt = new List<int>();
        while (k > 0)
        {
            klist.Add(k % 10);
            k = k / 10;
        }
        klist.Reverse();
        int i = A.Length - 1, j = klist.Count - 1;
        int carryOn = 0;
        while (i >= 0 || j >= 0)
        {
            if (i < 0 || j < 0)
            {
                int temp = (i < 0 ? klist[j] : A[i]) + carryOn;
                carryOn = temp >= 10 ? 1 : 0;
                rslt.Add(temp >= 10 ? temp - 10 : temp);
                    
            }
            else
            {
                int temp = A[i] + klist[j] + carryOn;
                carryOn = temp >= 10 ? 1 : 0;
                rslt.Add(temp >= 10 ? temp - 10 : temp);
            }
            i--; j--;
        }
        if (carryOn == 1) rslt.Add(1);
        rslt.Reverse();
        return rslt;
    }
}
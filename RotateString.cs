//https://leetcode.com/problems/rotate-string/


public class Solution {
    public bool RotateString(string A, string B) {
        if(A == "" && B == "") return true;
        if (A == B || A.Length != B.Length) return false;
        var a = A.ToCharArray();
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                var temp = a[j + 1];
                a[j + 1] = a[j];
                a[j] = temp;
            }
            var temp2 = new string(a);
            if (temp2 == B) return true;
        }
        return false;
    }
}
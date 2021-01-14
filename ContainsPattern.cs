//https://leetcode.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/

public class Solution {
    public bool ContainsPattern(int[] arr, int m, int k) {
        string a = String.Join("", arr);
        string prev = "";
        int count = 0;
        for (int i = 0; i + m <= arr.Length; i++)
        {
            string temp = "";
            prev = a.Substring(i, m);
            count = 0;
            for (int j = i; j + m <= arr.Length; j++)
            {
                temp = a.Substring(j, m);
                if (temp == prev) count++;
                else break;
                j += m - 1;
                prev = temp;
            }
            if (count >= k) return true;
        }
        return false;
    }
}
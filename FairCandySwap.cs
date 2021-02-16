//https://leetcode.com/problems/fair-candy-swap/

public class Solution {
    public int[] FairCandySwap(int[] A, int[] B) {
        int temp = 0, totalA = 0, totalB = 0;
        HashSet<int> setB = new HashSet<int>();
        for (int i = 0; i < A.Length || i < B.Length; i++)
        {
            if (i < A.Length) totalA += A[i];
            if (i < B.Length) { totalB += B[i]; setB.Add(B[i]); }
        }
        temp = (totalA + totalB) / 2;
        foreach (var item in A)
            if (setB.Contains(temp - (totalA - item))) return new int[] { item, temp - (totalA - item) };
        return new int[] { 0, 0 };
    }
}
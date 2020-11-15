//https://leetcode.com/problems/check-if-n-and-its-double-exist/




public class Solution {
    public bool CheckIfExist(int[] arr) {
        var hashSet = new HashSet<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] % 2 == 0 && hashSet.Contains(arr[i] / 2)) || hashSet.Contains(arr[i] * 2))
                return true;
            
            if (!hashSet.Contains(arr[i])) hashSet.Add(arr[i]);
        }
        return false;
    }
}
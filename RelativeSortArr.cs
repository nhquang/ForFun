
//https://leetcode.com/problems/relative-sort-array/

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var dict1 = new Dictionary<int,int>();
        var dict2 = new Dictionary<int,int>();
        for(int i = 0; i < arr2.Length; i++) dict1.Add(i, arr2[i]);
        for(int i = 0; i < arr1.Length; i++){
            if(dict2.ContainsKey(arr1[i])) dict2[arr1[i]]++;
            else dict2.Add(arr1[i], 1);
        }
        int j = 0, pos = 0;
        while (dict1.ContainsKey(pos))
        {
            for (int i = 1;i <= dict2[dict1[pos]]; i++)
            {
                arr1[j] = dict1[pos];
                j++;
            }
            dict2.Remove(dict1[pos]);
            pos++;
        }
        var sorted = dict2.Keys.OrderBy(i => i).ToArray();
        for(int i = 0; i < sorted.Length; i++)
        {
            for (int temp = 1; temp <= dict2[sorted[i]]; temp++)
            {
                arr1[j] = sorted[i];
                j++;
            }
        }
        return arr1;
    }
}


//O(nlogn)
public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var set = new HashSet<int>();
        int[] rslt = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            if (!set.Contains(arr[i])) set.Add(arr[i]);

        var sortedArr = set.ToArray();
        Array.Sort(sortedArr);
        for(int i = 0; i < arr.Length; i++){
            int rank = BinarySearch(sortedArr, 0, sortedArr.Length - 1, arr[i]);
            rslt[i] = rank + 1;
        }
        return rslt;
    }
    int BinarySearch(int[] arr, int l,int r, int tar){
        if(r >= l){
            int mid = l + (r - l) / 2; 
            if(arr[mid] == tar) return mid;
            else if(tar < arr[mid]) return BinarySearch(arr, 0, mid - 1, tar);
            else if(tar > arr[mid]) return BinarySearch(arr, mid + 1, r, tar);
        }
        return -1;
    }
}

//O(nlogn)
public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var sortedArr = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++)
            sortedArr[i] = arr[i];
        Array.Sort(sortedArr);
        int rank = 1;
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < sortedArr.Length; i++){
            if(!dict.ContainsKey(sortedArr[i])) { dict.Add(sortedArr[i], rank); rank++; }
        }
        for(int i = 0; i < arr.Length; i++){
            arr[i] = dict[arr[i]];
        }
        return arr;
    }
    
}
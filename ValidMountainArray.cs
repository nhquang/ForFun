//https://leetcode.com/problems/valid-mountain-array/

public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if (arr.Length < 3) return false;
        bool peakReached = false;
        
        int peak = arr.Max(); 
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (!peakReached && arr[i] == peak)
            {
                peakReached = true;
                if((arr.Length - 2) == i) { if (arr[i + 1] >= arr[i]) return false;}         	//if peak is the second last element
                else if(i == 0) return false;													//if peak is the first element
                    
            }
            else if (!peakReached && arr[i] >= arr[i + 1]) return false;						//going up
            else if (peakReached && arr[i] <= arr[i + 1]) return false;							//going down
        }
        return peakReached ? true : false;
    }
}
	//https://leetcode.com/problems/kth-missing-positive-number/


	public int FindKthPositive(int[] arr, int k)
    {
        int i = 1, j = 0, missing = 0;
        while (true)
        {
            if (j < arr.Length)
            {
                if(i != arr[j]){
                    j--;
                    missing++;
                } 
            }
            else missing++;
            if (missing == k) return i;
            i++; j++;
        }
    }
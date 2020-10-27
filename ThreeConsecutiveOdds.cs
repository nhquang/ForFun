	//https://leetcode.com/problems/three-consecutive-odds/


	public bool ThreeConsecutiveOdds(int[] arr) {
        for(int i = 1; i < arr.Length - 1; i++){
			if(arr[i-1] % 2 != 0 && arr[i] % 2 != 0 && arr[i+1] % 2 != 0) return true;
		}
        return false;
    }
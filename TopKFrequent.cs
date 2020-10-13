		//https://leetcode.com/problems/top-k-frequent-elements/
		
		
		public static int[] TopKFrequent(int[] nums, int k)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.ContainsKey(nums[i])) pairs[nums[i]]++;
                else pairs.Add(nums[i], 1);
            }
            var ordered = pairs.OrderByDescending(e => e.Value).ToArray();
            var rslt = new List<int>();
            for(int i = 0; i < k; i++)
            {
                rslt.Add(ordered.ElementAt(i).Key);
            }
            return rslt.ToArray();

        }
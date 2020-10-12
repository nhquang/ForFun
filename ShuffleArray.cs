		//https://leetcode.com/problems/shuffle-the-array/
		
		public static int[] Shuffle(int[] nums, int n)
        {
            int[] xs = null, ys = null;
            List<int> rslt = new List<int>();
            Array.Copy(nums, xs, n);
            Array.Copy(nums, n, ys, 0, n);
            for(int i = 0; i < n; i++)
            {
                rslt.Add(xs[i]);
                rslt.Add(ys[i]);
            }

            return rslt.ToArray();
        }
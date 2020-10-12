		//https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
		
		public static int MinStartValue(int[] nums)
        {
            int bse = 1;
            while (true)
            {
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == 0)
                    {
                        sum = bse + nums[i];
                        if (sum < 1) break;
                    }
                    else if (i > 0 && i < nums.Length - 1)
                    {
                        sum += nums[i];
                        if (sum < 1) break;
                    }
                    else
                        return bse;

                }
                bse++;
            }
        }
public static int[] TwoSum(int[] nums, int target)
{
    int baseNum = 0;
    var rslt = new int[] { };
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[baseNum] + nums[j] == target)
            {
                rslt = new int[2] { baseNum, j };
                goto Done;
            }
        }
        baseNum++;
    }
    Done:
    return rslt;        
    
}
//https://leetcode.com/problems/two-sum/
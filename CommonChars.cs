//https://leetcode.com/problems/find-common-characters/

public class Solution {
    public IList<string> CommonChars(string[] A) {
        var list = new List<char[]>();
        var rslt = new List<string>();
        for (int i = 0; i < A.Length; i++) list.Add(A[i].ToCharArray());
        for (int i = 0; i < list[0].Length; i++)
        {
            int count = 1;
            for (int j = 1; j < list.Count; j++)
            {
                for (int h = 0; h < list[j].Length; h++)
                {
                    if (list[j][h] == list[0][i])
                    {
                        list[j][h] = '\0';
                        count++; break;
                    }
                }
            }
            if (count == list.Count) rslt.Add(list[0][i].ToString());
        }
        return rslt;
    }
}
//https://leetcode.com/problems/long-pressed-name/


public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        int j = 0;
        if(typed.Length < name.Length) return false;
        for (int i = 0; i < name.Length; i++)
        {
            int count = 0, count2 = 0;
            char temp = name[i];
            while (i < name.Length && temp == name[i])
            {
                count++; i++;
            }
            if (j == typed.Length || name[i - count] != typed[j]) return false;
            for (j = j; j < typed.Length && typed[j] == name[i-count]; j++)
                count2++;
            if (count2 < count) return false;
            i--;
        }
        if (j < typed.Length) return false;
        return true;
    }
}
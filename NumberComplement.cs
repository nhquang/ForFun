//https://leetcode.com/problems/number-complement/




public class Solution {
    public int FindComplement(int num)
    {
        if (num <= 1) return num == 0 ? 1 : 0;
        var binary = new List<int>();
        while (num != 0)
        {
            if (num % 2 == 0) binary.Add(1);
            else binary.Add(0);
            num /= 2;
        }
        binary.Reverse();
        bool leadingZeroes = true;
        int i = 0, h = 1, rslt = 0;
        while (leadingZeroes)
        {
            if (binary[i] == 0) { binary.RemoveAt(i); i--; if(binary.Count == 0) leadingZeroes = false;}
            else leadingZeroes = false;
            i++;
        }
        for(int j = 0; j < binary.Count; j++)
        {
            rslt += Convert.ToInt32(Math.Pow(2.0, Convert.ToDouble(binary.Count - h)) * binary[j]);
            h++;
        }
        return rslt;
    }
}
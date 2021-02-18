public class Solution {
    public bool LemonadeChange(int[] bills) {
        var dict = new Dictionary<int,int>();
        dict.Add(5,0); dict.Add(10,0); dict.Add(20,0);
        for(int i = 0; i < bills.Length;i++){
            int temp = bills[i] - 5;
            if (temp == 5 && dict[5] >= 1) dict[5]--;
            else if(temp == 15 && dict[5] >= 1 && dict[10] >= 1) { dict[5]--; dict[10]--; }
            else if(temp == 15 && dict[5] >= 3) dict[5] -= 3;
            else if (temp != 0)return false;
            dict[bills[i]]++;
        }
        return true;
    }
}
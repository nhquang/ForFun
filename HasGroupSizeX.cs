//https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/


public class Solution {
    public bool HasGroupsSizeX(int[] deck) {
        var dict = new Dictionary<int, int>();
        if (deck.Length == 1) return false;
        for (int i = 0; i < deck.Length; i++)
        {
            if (dict.ContainsKey(deck[i])) dict[deck[i]]++;
            else dict.Add(deck[i], 1);
        }
        int temp = dict.ElementAt(0).Value;
        for(int i = 2; i <= temp; i++){
            int count = 0;
            foreach(var item in dict){
                if(item.Value < 2) return false;
                else if(item.Value % i == 0) count++;
            }
            if(count == dict.Count) return true;
        }
        return false;
    }
}
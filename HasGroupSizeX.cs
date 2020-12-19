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
        int j = 1;
        while (j < dict.ElementAt(0).Value)
        {
            bool skip = false;
            j++;
            while (dict.ElementAt(0).Value % j != 0) j++;
            foreach (var item in dict)
            {
                if (item.Value < 2) return false;
                else
                    if (item.Value % j != 0) { skip = true; break; }
            }
            if(!skip) return true;
        }
        return false;
    }
}
//https://leetcode.com/problems/count-items-matching-a-rule/

public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        var dict = new Dictionary<string, int>();
        dict.Add("type", 0);
        dict.Add("color",1);
        dict.Add("name", 2);
        int count = 0;
        for(int i = 0; i < items.Count; i++){
            if(items[i][dict[ruleKey]] == ruleValue) count++;
        }
        return count;
    }
}
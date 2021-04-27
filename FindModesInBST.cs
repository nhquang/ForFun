//https://leetcode.com/problems/find-mode-in-binary-search-tree/

public class Solution {
    Dictionary<int,int> dict = new Dictionary<int,int>();
    public int[] FindMode(TreeNode root) {
        Traverse(root);
        int max = int.MinValue;
        var rslt = new HashSet<int>();
        foreach(var item in dict){
            if(item.Value > max){
                max = item.Value;
                rslt.Clear();
                rslt.Add(item.Key);
            }
            else if (item.Value == max) rslt.Add(item.Key);
        }
        return rslt.ToArray();
    }
    void Traverse(TreeNode root){
        if(root != null){
            Traverse(root.left);
            Traverse(root.right);
            if(dict.ContainsKey(root.val)) dict[root.val]++;
            else dict.Add(root.val, 1);
        }
    }
}
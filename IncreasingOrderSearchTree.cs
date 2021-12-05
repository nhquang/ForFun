//https://leetcode.com/problems/increasing-order-search-tree/

public class Solution {
    List<int> vals = new List<int>();
    public TreeNode IncreasingBST(TreeNode root) {
        InOrder(root);
        vals.Reverse();
        TreeNode prev = null;
        foreach(var item in vals){
            var temp = new TreeNode(item, null, prev);
            prev = temp;
        }
        return prev;
    }
    void InOrder(TreeNode root){
        if(root == null)
            return;
        InOrder(root.left);
        vals.Add(root.val);
        InOrder(root.right);
    }
}
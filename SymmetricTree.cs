//https://leetcode.com/problems/symmetric-tree/

public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return Symmetric(root.left, root.right);
    }
    bool Symmetric(TreeNode left, TreeNode right){
        if(left == null && right == null) 
            return true;
        if(left == null || right == null)
            return false;
        if(left.val != right.val)
            return false;
        return Symmetric(left.left, right.right) && Symmetric(left.right, right.left);
    }
}
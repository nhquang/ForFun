//https://leetcode.com/problems/binary-tree-inorder-traversal/


public class Solution {
    List<int> rs = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        traverse(root);
        return rs;
    }
    void traverse(TreeNode root){
        if(root != null){
            traverse(root.left);
            rs.Add(root.val);
            traverse(root.right);
        }
    }
}
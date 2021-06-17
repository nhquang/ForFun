//https://leetcode.com/problems/binary-tree-postorder-traversal/

public class Solution {
    List<int> rs = new List<int>();
    public IList<int> PostorderTraversal(TreeNode root) {
        PostOrderTraversal(root);
        return rs;
    }
    void PostOrderTraversal(TreeNode root){
        if(root != null){
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            rs.Add(root.val);
        }
    }
}
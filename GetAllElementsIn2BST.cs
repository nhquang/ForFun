
//https://leetcode.com/problems/all-elements-in-two-binary-search-trees/

public class Solution {
    List<int> rs = new List<int>();
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        PostOrderTraversal(root1);
        PostOrderTraversal(root2);
        return rs.OrderBy(i => i).ToList();
    }
    void PostOrderTraversal(TreeNode root){
        if(root != null){
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            rs.Add(root.val);
        }
    }
}
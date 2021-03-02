//https://leetcode.com/problems/range-sum-of-bst/


public class Solution {
    public int RangeSumBST(TreeNode root, int L, int R) {
        int sum = 0;
        for(int i = L; i <= R; i++){
            sum += BinarySearch(root, i);
        }
        return sum;
    }
    int BinarySearch(TreeNode node, int tar){
        if(node != null){
            if(node.val == tar) return tar;
            else if (tar > node.val) return BinarySearch(node.right, tar);
            else return BinarySearch(node.left, tar);
        }
        return 0;
    }
}


public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
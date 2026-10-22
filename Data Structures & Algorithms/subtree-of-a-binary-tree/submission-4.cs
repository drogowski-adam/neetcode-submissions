/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root != null && subRoot == null) return true;
        if(root == null && subRoot != null) return false;

        if(isSameTree(root,subRoot)){
            return true;
        }
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }
    public bool isSameTree(TreeNode s, TreeNode t){
        if(s == null && t == null) return true;
        if(s == null || t == null || s.val != t.val) return false;

        return isSameTree(s.left,t.left) && isSameTree(s.right,t.right);
    }
}

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
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        List<List<int>> res = new();

        while(q.Count > 0){
            List<int> level = new();
            int qLen = q.Count;
            for(int i = 0; i < qLen; i++){
                TreeNode node = q.Dequeue();
                if(node != null){
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                    level.Add(node.val);             
                }   
            }
            if(level.Count > 0) res.Add(level);
        }
        return res;
    }
}

public class Solution {

    public void UpdatePath(int r,int c,int[][] board){
        if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length)
            {
                return;
            }

        if(r == board.Length - 1 && c < board[0].Length - 1) board[r][c] = board[r][c+1];

        if(r < board.Length - 1 && c == board[0].Length - 1) board[r][c] = board[r+1][c];

        if(r < board.Length - 1 && c < board[0].Length - 1) board[r][c] = board[r + 1][c] + board[r][c+1];
    }

    public int UniquePaths(int m, int n) {
        int[][] board = new int[m][];
     
        for (int i = 0; i < m; i++) {
            board[i] = new int[n];
        }
        board[(m-1)][(n-1)] = 1;

        for(int r = m - 1; r >= 0; r--){
            for(int c = n - 1; c >= 0; c--){
                UpdatePath(r,c,board);
            }
        }
        return board[0][0];
        

    }
}

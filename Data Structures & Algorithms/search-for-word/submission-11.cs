public class Solution {

    public bool Dfs(int r, int c, int i, char[][] board, string word){
        if(word.Length == i) return true;

        if(r < 0 || c < 0 || r >= board.Length || c >= board[0].Length || board[r][c] == '#' || board[r][c] != word[i]) return false;

        board[r][c] = '#';
        bool res = Dfs(r-1,c,i+1,board,word) ||
        Dfs(r+1,c,i+1,board,word) ||
        Dfs(r,c-1,i+1,board,word) ||
        Dfs(r,c+1,i+1,board,word);

        board[r][c] = word[i];
        return res;
    }

    public bool Exist(char[][] board, string word) {
        for(int r = 0; r < board.Length; r++){
            for(int c = 0; c < board[0].Length; c++){
                if(Dfs(r,c,0,board,word)) return true;
            }
        }
        return false;
    }
}

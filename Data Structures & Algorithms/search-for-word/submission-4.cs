public class Solution {

    public bool DFS(int r, int c, int i, char[][] board, string word){
        if(i == word.Length){
            return true;
        }

        if(c < 0 || r < 0 || r >= board.Length || c >= board[0].Length ||
            board[r][c] != word[i] || board[r][c] == '#'){
                return false;
            }
        board[r][c] = '#';
        bool res = DFS(r + 1, c, i + 1, board, word) ||
        DFS(r - 1, c, i + 1, board, word) ||
        DFS(r, c+1, i + 1, board, word) ||
        DFS(r, c-1, i + 1, board, word);
        board[r][c] = word[i];

        return res;
    }

    public bool Exist(char[][] board, string word) {
        
        for(int r = 0; r < board.Length; r++){
            for(int c = 0; c < board[0].Length; c++){
                if(DFS(r,c,0,board,word)) return true;
            }
        }
        return false;
    }
}

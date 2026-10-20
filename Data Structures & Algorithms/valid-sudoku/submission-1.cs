public class Solution {
    public bool IsValidSudoku(char[][] board) {
    
        for(int i = 0; i < 9; i++){
            HashSet<char> rows = new();
            for(int j = 0; j < 9; j++){
                if(board[i][j] == '.') continue;
                if(!rows.Add(board[i][j])) return false;
            }
        }

        for(int i = 0; i < 9; i++){
            HashSet<char> cols = new();
            for(int j = 0; j < 9; j++){
                if(board[j][i] == '.') continue;
                if(!cols.Add(board[j][i])) return false;
            }
        }

        for(int boxRow = 0; boxRow < 9; boxRow += 3){
            for(int boxCol = 0; boxCol < 9; boxCol += 3){
                HashSet<char> box = new();
                for(int i = boxRow; i < boxRow + 3; i++){
                    for(int j = boxCol; j < boxCol + 3; j++){
                        if(board[i][j] == '.') continue;
                        if(!box.Add(board[i][j])) return false;
                    }
                }

            }

        }

        return true;


    }
}

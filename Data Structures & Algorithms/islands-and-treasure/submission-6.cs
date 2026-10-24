public class Solution {

    private Queue<(int,int)> q = new();
    private HashSet<(int,int)> set = new();

    public void AddRoom(int r, int c, int[][] grid){
        if(r < 0 || c < 0 || r == grid.Length || c == grid[0].Length
         || !set.Add((r,c)) || grid[r][c] == -1) return;
        
       
        q.Enqueue((r,c));
    }

    public void islandsAndTreasure(int[][] grid) {

        for(int r = 0; r < grid.Length; r++){
            for(int c = 0; c < grid[0].Length; c++){
                if(grid[r][c] == 0){
                    set.Add((r,c));
                    q.Enqueue((r,c));
                }
            }
        }   
        int dist = 0; 
        while(q.Count > 0){
            int size = q.Count;

            for(int i = 0; i < size; i++){
                var (r,c) = q.Dequeue();
                grid[r][c] = dist;

                AddRoom(r-1,c,grid);
                AddRoom(r+1,c,grid);
                AddRoom(r,c-1,grid);
                AddRoom(r,c+1,grid);
            }
        dist++;
        }
    }
}


    public class Solution
    {

        public int NumIslands(char[][] grid)
        {
            char[][] tempGrid = grid;
            int AllGroups = 0;

            for(int i = 0; i< tempGrid.Length; i++)
            {
                for(int j = 0; j < tempGrid[0].Length; j++)
                {
                    if (tempGrid[i][j] == '0')
                        continue;
                    else if (tempGrid[i][j] == '1')
                    {
                        RecursiveGroup(tempGrid, i, j);
                        AllGroups++;
                    }
                }
            }

            return AllGroups;
        }
        
        private static void RecursiveGroup(char[][] grid,int iIndex, int jIndex)
        {
                if (iIndex < 0 || jIndex < 0 || iIndex >= grid.Length || jIndex >= grid[0].Length)
                    return;

                if (grid[iIndex][jIndex] == '1')
                    grid[iIndex][jIndex] = '0';
                    //AddToGroup(MyGroup, iIndex, jIndex);
                else
                    return;

                RecursiveGroup(grid, iIndex - 1, jIndex); //check above
                RecursiveGroup(grid, iIndex + 1, jIndex); //check below
                RecursiveGroup(grid, iIndex, jIndex - 1); //check right
                RecursiveGroup(grid, iIndex, jIndex + 1); //check left
        }

    }
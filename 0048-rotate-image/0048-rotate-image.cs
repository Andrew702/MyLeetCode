/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
using System.Dynamic;
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            // 3 swap
            // 4 go next -- till cell in last col
            // 5 go next row after 1st col
            // 6 go next till cell in 2nd last

            int row;
            int col;
            int layer = 0;
            // 1-start from first cell
            for (row = 0; row < n - 1; row++)
            {
                for (col = row; col < n - row - 1; col++)
                {
                    GetNext(row, col, n - 2 *row, out int newI, out int newJ , layer);
                    swap(matrix, row, col, newI, newJ);
                    GetNext(newI, newJ, n - 2 * row, out newI, out newJ , layer);
                    swap(matrix, row, col, newI, newJ);
                    GetNext(newI, newJ, n - 2 * row, out newI, out newJ , layer);
                    swap(matrix, row, col, newI, newJ);
                }
                layer++;

            }
        }

        private static void swap(int[][]matrix,int i1, int j1 , int i2, int j2)
        {
            (matrix[i1][j1], matrix[i2][j2]) = (matrix[i2][j2], matrix[i1][j1]);
        }

        private enum Directon { right, down, left , up }

        public static void  GetNext(int i, int j, int n, out int newI, out int newJ , int layer)
        {
            newJ = j;
            newI = i;
            int steps = n-1;
            while(steps!=0)
            {
                Directon mydirection = Directon.right;
                if (newJ == n - 1 + layer  && newI < n-1 + layer) // i hit right  
                    mydirection = Directon.down;

                if (newI == n - 1 + layer && newJ > 0 + layer) // i hit bottom
                    mydirection = Directon.left;

                if (newI > 0 + layer && newJ == 0 + layer) // i hit left
                    mydirection = Directon.up;

                if(mydirection == Directon.right) { newJ++; }
                else if(mydirection == Directon.down) { newI++; }
                else if(mydirection == Directon.left) { newJ--; }
                else if(mydirection == Directon.up) { newI--; }
                steps--;
            }
        }
    }
    // @lc code=end



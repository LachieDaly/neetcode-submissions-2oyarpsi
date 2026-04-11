public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int[][] transposedMatrix = new int[matrix[0].Length][];
        for (int i = 0; i < matrix[0].Length; i++)
        {
            transposedMatrix[i] = new int[matrix.Length];
            for (int j = 0; j < matrix.Length; j++) 
            {
                transposedMatrix[i][j] = matrix[j][i];
            }
        }
        return transposedMatrix;
    }
}
namespace ClassLibrary1
{
    public class Class1
    {
        public static double[] GetMaxColumn(double[,] matrix)
        {
            double[] maxColumn = new double[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double max = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxColumn[i] = max;
            }
            return maxColumn;
        }
    }
}

namespace ClassLibrary
{
    public class OurClass
    {
        public static int Multimatrix(int[] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++) sum += matrix[i];
            return sum;

        }
    }
}

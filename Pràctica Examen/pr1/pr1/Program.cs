using System;

namespace MyApplication
{

    class Matriu
    {
        static void Main()
        {

            int[] matrix = {4,1,2,5,7};

            for(int i = 0; i < matrix.Length-1; i++)
            {
                for (int j = i+1;  j < matrix.Length; j++)
                {
                    if (matrix[i] > matrix[j])
                    {
                        int aux = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = aux;
                    }
                }
            }

        }
    }


}
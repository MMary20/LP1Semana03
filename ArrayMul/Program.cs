using System;

class ArrayMul
{
    static void Main(string[] args)
    {
        float[,] A = {
            { float.Parse(args[0]), float.Parse(args[1]) },
            { float.Parse(args[2]), float.Parse(args[3]) }
        };
        float[] B = { float.Parse(args[4]), float.Parse(args[5]) };

        for (int i = 0; i < 2; i++)
        {
            float resultado = 0;
            for (int j = 0; j < 2; j++)
            {
                resultado += A[i, j] * B[j];
            }

            Console.WriteLine($"| {resultado,7:F2} |");
        }
    }
}



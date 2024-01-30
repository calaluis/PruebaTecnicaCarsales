class TriangulodePascalCL
{
    static void Main()
    {
        int K = 4; // K es el tamaño de la pirámide de pascal
        MostrarTrianguloPascal(K);
    }

    static void MostrarTrianguloPascal(int K)
    {
        for (int n = 0; n < K; n++)
        {
            for (int r = 0; r <= n; r++)
            {
                Console.Write(CalcularCoeficienteBinomial(n, r) + " ");
            }
            Console.WriteLine();
        }
    }

    static long CalcularCoeficienteBinomial(int n, int r)
    {
        return Factorial(n) / (Factorial(r) * Factorial(n - r));
    }

    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
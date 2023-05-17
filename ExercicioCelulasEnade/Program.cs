using System;

public class Program
{
    private static int[,] matrix = new int[,]
    {   //0  1  2  3  4  5  6  7  8  9
    	{ 0, 0, 1, 1, 0, 1, 1, 1, 0, 1 }, // 0
    	{ 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 }, // 1
    	{ 0, 0, 0, 1, 1, 0, 0, 1, 0, 1 }, // 2
    	{ 1, 1, 1, 0, 0, 1, 0, 0, 1, 1 }, // 3
    	{ 0, 0, 1, 1, 0, 1, 0, 0, 1, 0 }, // 4
    	{ 1, 0, 0, 0, 1, 0, 1, 0, 1, 1 }, // 5
    	{ 0, 1, 1, 0, 1, 0, 1, 1, 1, 0 }, // 6
    	{ 1, 0, 1, 0, 1, 0, 1, 0, 0, 1 }, // 7
    	{ 0, 1, 1, 0, 0, 1, 1, 0, 0, 0 }, // 8
    	{ 1, 0, 1, 1, 0, 1, 0, 1, 0, 1 }  // 9
	};

    public static void Main()
    {
        int i = 7;
        int j = 2;
        Console.WriteLine($"Novo valor para a célula: {GetNovoEstadoCelular(matrix, i, j)}");
        Console.WriteLine();
    }

    public static int GetNovoEstadoCelular(int[,] matrix, int i, int j)
    {
        Console.WriteLine($"Analisando a célula linha {i}, coluna {j}. Estado da célula: {matrix[i,j]}");

        Console.WriteLine();

        int qtdVizinhos = 0;

        Console.WriteLine("Células vivas: ");

        Console.WriteLine();

        // Analisa os vizinhos horizontais
        if (matrix[i, j - 1] == 1)
        {
            Console.WriteLine("Horizontal esquerdo");
            qtdVizinhos++;
        }

        if (matrix[i, j + 1] == 1)
        {
            Console.WriteLine("Horizontal direito");
            qtdVizinhos++;
        }

        // Analisa os vizinhos verticais
        if (matrix[i - 1, j] == 1)
        {
            Console.WriteLine("Vertical superior");
            qtdVizinhos++;
        }

        if (matrix[i + 1, j] == 1)
        {
            Console.WriteLine("Vertical inferior");
            qtdVizinhos++;
        }

        // Analisa os vizinhos diagonais
        if (matrix[i - 1, j - 1] == 1)
        {
            Console.WriteLine("Diagonal superior esquerda");
            qtdVizinhos++;
        }

        if (matrix[i + 1, j + 1] == 1)
        {
            Console.WriteLine("Diagonal inferior direita");
            qtdVizinhos++;
        }

        if (matrix[i - 1, j + 1] == 1)
        {
            Console.WriteLine("Diagnonal superior direita");
            qtdVizinhos++;
        }

        if (matrix[i + 1, j - 1] == 1)
        {
            Console.WriteLine("Diagonal inferior esquerda");
            qtdVizinhos++;
        }

        Console.WriteLine();

        Console.WriteLine($"Quantidade de vizinhos vivos: {qtdVizinhos}");

        Console.WriteLine();

        if (qtdVizinhos < 2)
            return 0;

        else if (qtdVizinhos == 3)
        {

            if (matrix[i, j] == 0)
                return 1;
            else
                return matrix[i, j];
        }
        else if (qtdVizinhos > 3 && matrix[i, j] == 1)
            return 0;
        else
            return matrix[i, j];
    }
}

using System;

namespace Exercicio_Fixação_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de linhas e colunas da matriz:");
            string[] vetor = (Console.ReadLine().Split(' '));
            int linha = int.Parse(vetor[0]);
            int coluna = int.Parse(vetor[1]);

            int[,] matriz = new int[linha, coluna];
            Console.WriteLine("Informe os valores da matriz: ");

            for (int i = 0; i < linha; i++)
            {
                string[] vetor2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(vetor2[j]);
                }
            }

            Console.Write("Informe o valor que deseja procurar:");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (valor == matriz[i, j])
                    {
                        Console.WriteLine("Posição: {0}, {1}", i, j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < coluna - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < linha - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }

                    }
                }
            }

        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes_FIAP_Aula5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Maneiras de declarar um vetor
            /*

            // Definindo o tamanho:
            int[] vetorValores = new int[5];

            // Definindo o tamanho e atribuindo valores
            string[] nomes = new string[3] { "Rafael", "Matheus", "Oliveira" };

            // Atribuindo os valores sem definir o tamanho. O tamanho é inerente à quantidade de valores que for inserida.
            int[] idades = new int[] { 19, 84, 720, 4, 37, 143, 14 };

            // Sem usar o operador de instanciação 'new'
            string[] cores = {"azul", "branco", "cinza"}

            */
            #endregion

            #region Exercício básico com vetor
            /*
            int[] vetorNumeros = new int[5];
            int i, soma = 0;
            
            for(i = 0; i < vetorNumeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetorNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            soma = vetorNumeros.Sum();
            Console.WriteLine($"\nA soma de todos os elementos do vetor é: {soma}");
            
            for (i = 0; i < vetorNumeros.Length; i++)
            {
                Console.WriteLine($"\nPosição: {i} | Valor: {vetorNumeros[i].ToString()}");
            }

            Console.ReadKey();
            */
            #endregion

            #region Exercício com cópia e reversão de vetor
            /*
            int[] vetorA = new int[5] { 1, 2, 3, 4, 5 };
            int[] vetorB = new int[vetorA.Length];
            int[] vetorC = new int[vetorA.Length];

            Array.Copy(vetorA, vetorB, vetorA.Length);
            Array.Reverse(vetorB);

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine($"\nPosição: {i} ||| Vetor A: {vetorA[i].ToString()} | Vetor B: {vetorB[i].ToString()}");
            }

            Console.ReadKey();
            */
            #endregion

            #region Exercício com vetor de notas de alunos e laço
            /*
            double[] notasAlunos = new double[10];
            double somaNotas = 0, media = 0;

            for(int i = 0; i < notasAlunos.Length; i++)
            {
                Console.WriteLine($"Digite a note do {i + 1}º aluno: ");
                notasAlunos[i] = Convert.ToDouble(Console.ReadLine());
                somaNotas += notasAlunos[i];
            }

            media = somaNotas / notasAlunos.Length;
            Console.WriteLine($"\n\tA média desta turma é: {media.ToString("F2")}");
            Console.ReadKey();
            */
            #endregion



            #region Exibindo todos os elementos de uma lista com apenas uma linha de código
            /*
             
            List<int> listaTeste = new List<int>();
            listaTeste = Enumerable.Range(10, 20).ToList();
            Console.WriteLine($"{string.Join(", ", listaTeste)}"); // Plota do 10 até o 29

            */
            #endregion



            #region Maneiras de declarar uma matriz
            /*
            
            // Declarando uma matriz de 6 elementos(3 linhas x 2 colunas):
            int[,] matrizNumeros = new int[3, 2];

            // Declarando a matriz e atribuindo valores nas declarações:
            int[,] matrizNumeros2 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // Declarando a matrix, deixando o tamanho por conta da declaração, que no caso abaixo é 2x2:
            string[,] casais = new string[,] { { "Rafael", "Carla" }, { "André", "Cristiane" } };
            
            */
            #endregion

            #region Exercício básico com matriz e laço
            /*
            int[,] matrizNumeros = new int[3, 2];
            int linha, coluna, soma = 0;

            for (linha = 0; linha < 3; linha++)
            {
                for (coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine($"Digite o elemento da matriz[{linha},{coluna}]: ");
                    matrizNumeros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }            
            Console.ReadKey();
            */
            #endregion

            #region Exercício básico com soma de elementos de uma matriz
            /*
            int[,] matrizNumeros = new int[2, 2] { { 10, 20 }, { 100, 200 } };
            int soma = matrizNumeros.Cast<int>().Sum();

            Console.WriteLine($"A soma de todos os elementos da matriz: {soma}");
            Console.ReadKey();
            */
            #endregion

            #region Desafio com matriz

            int[,] matrizNumeros = new int[4, 4]
            {
                { 1, 2, 3, 4 }, // Somar
                { 10, 20, 30, 40 }, // Obter Média
                { 100, 200, 300, 400 }, // Multiplicar com a linha abaixo
                { 1000, 2000, 3000, 4000 } //
            };

            int somaPrimeiraLinha = matrizNumeros.Cast<int>().Take(4).Sum();
            Console.WriteLine($"Soma dos elementos da primeira linha: {somaPrimeiraLinha}");

            int mediaSegundaLinha = (int)matrizNumeros.Cast<int>().Skip(4).Take(4).Average();
            Console.WriteLine($"Média dos elementos da segunda linha: {mediaSegundaLinha}");

            for (int i = 0; i < 4; i++)
            {
                int produtoColunas = matrizNumeros[3 - 1, i] * matrizNumeros[4 - 1, i];
                Console.WriteLine($"Matriz[2,{i}] * Matriz[3,{i}] = {produtoColunas}");
            }

            #endregion

            #region Somando os elementos da diagonal principal da matriz

            int somaDiagonalPrincipal = Enumerable.Range(0, 4).Sum(i => matrizNumeros[i, i]);
            Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");

            #endregion

            Console.ReadKey();

        }
    }
}

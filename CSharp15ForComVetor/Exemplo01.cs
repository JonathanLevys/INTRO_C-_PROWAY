using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp15ForComVetor
{
    internal class Exemplo01
    {
        public void Executar()
        {
            //            Console.Write("Digite a quantodade de produtos: ");
            //            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            //            string[] nomes = new string[quantidadeProdutos];
            //            double[] preçosUnitarios = new double[quantidadeProdutos];
            //            int[] quantidades = new int[quantidadeProdutos];

            //            for (int i = 0; i < nomes.Length; i = i +1)
            //            {
            //                Console.Write("\nDigite o nome do produto: ");
            //                nomes[i] = Console.ReadLine();
            //                Console.Write("\nDigite a quantidade para '" + nomes[i] + "': ");
            //                quantidades[i] = Convert.ToInt32(Console.ReadLine());
            //                Console.Write("\nDigite o preço unitário para '" + nomes[i] + "': ");
            //                preçosUnitarios[i] = Convert.ToDouble(Console.ReadLine());
            //            }

            //            double totalCompra = 0;
            //            for (int i = 0; i < nomes.Length; i = i + 1)
            //            {
            //                double totalProduto = quantidades[i] * preçosUnitarios[i];
            //                Console.WriteLine(nomes[i] + string.Format("{0:C}", totalProduto));

            //                totalCompra = totalCompra + totalProduto;
            //            }

            //            Console.WriteLine("Total " + string.Format("{0:C}" ,totalCompra));

            //        }
            //    }
            //}
            // Solicitar para 4 alunos(obrigatório utilização for)
            // nome
            // nota 1 
            // nota 2
            // nota 3
            // apresenta média dos alunos

            string[] nomes = new string[4];
            double[] nota1 = new double[nomes.Length];
            double[] nota2 = new double[nomes.Length];
            double[] nota3 = new double[nomes.Length];


            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.Write("Nome do aluno: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Nota 1: ");
                nota1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 2: ");
                nota2[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 3: ");
                nota3[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n");
            }


            Console.Clear();
            for (int i = 0; i < nomes.Length; i++)
            {
                double media = (nota1[i] + nota2[i] + nota3[i]) / 2;
                Console.WriteLine(nomes[i] + " Media das notas: " + media);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp15ForComVetor
{
    internal class Exemplo00
    {
        public void Executar()
        {
            string[] nomes = new string[4];
            string[] sobrenomes = new string[4];

            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.WriteLine("Dados do paciente " + (i + 1) + ":");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Sobrenome: ");
                sobrenomes[i] = Console.ReadLine();
                Console.WriteLine("\n");
            }


            Console.Clear();
            for(int i = 0; i < nomes.Length; i++)
            {
                string nomeCompleto = nomes[i] + " " + sobrenomes[i];
                Console.WriteLine("Nome completo: " + nomeCompleto);
            }
        }
    }
}

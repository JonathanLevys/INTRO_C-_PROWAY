using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17ListaObjetos
{
    internal class Exemplo00
    {
        public void Executar()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno paulo = new Aluno();
            paulo.Nome = "Paulo";
            paulo.Nota1 = 9.4;
            paulo.Nota2 = 8; 
            paulo.Nota3 = 7.6;

            alunos.Add(paulo);

            Aluno jose = new Aluno();
            jose.Nome = "José";
            jose.Nota1 = 5;
            jose.Nota2 = 4;
            jose.Nota3 = 3;
            alunos.Add(jose);

            //// apresentar o nome do primeiro aluno:
            //Console.WriteLine("Nome do 1° aluno: " + primeiroAluno.Nome);

            //// Apresentar o nome 
            //alunos.Remove = jose;

            
        }
    }
}

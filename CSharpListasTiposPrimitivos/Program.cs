///*
// *  Tipos Primitivos
// *   string
// *    int
// *    double
// *    char
// *    bool
// */

////Criar um vetor de 4 posiç~ioes
//// int[] numeros = new int[4]
////numeros[0] = 5;
////numeros[1] = 7;
////numeros[2] = 9;
////numeros[3] = 3;

//// Criar uma lista de numeros inteiros
//List<int> numeros = new List<int>();
//numeros.Add(5);
//numeros.Add(7);
//numeros.Add(9);
//numeros.Add(3);
//numeros.Add(10);

//// Remover um numero da Lista
//numeros.Remove(9); //Removido da posição 2 => [5,7,3,10] 

////Verificar se numero 10 existe na lista
//bool numero10ExisteNalista = numeros.Contains(10);
//Console.WriteLine("Lista contem numero 10: " + numero10ExisteNalista);

////Alterar o numero 5 da primeira(0) posição para o numero 6,
//numeros[0] = 6;

//Console.WriteLine("Números: ");
//Console.WriteLine(numeros[0]);
//Console.WriteLine(numeros[1]);
//Console.WriteLine(numeros[2]);
//Console.WriteLine(numeros[3]);


////Somar os numeros da lista e apresentar
//int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
//Console.WriteLine("Soma " + soma);

using CSharp16ListasTiposPrimitivos;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Exemplo01 exemplo01 = new Exemplo01();
exemplo01.Executar();

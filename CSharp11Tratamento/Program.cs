////Exceção: é algo que ocorre quando algo inesperado acontece.
////Exemplo: usuário deveri digtar um numero porém coloca espqços ou letras
//try
//{
//    int numero1 = Convert.ToInt32("10");
//    int numero2 = Convert.ToInt32("12p");

//    int soma = numero1 + numero2;

//    Console.WriteLine("Número 01: " + numero1);
//    Console.WriteLine("Número 02: " + numero2);
//    Console.WriteLine("Soma: " + soma);
//}
//catch(Exception e)
//{
//    Console.WriteLine("Aconteceu um erro na conversão de número");
//}

//Console.WriteLine("Programa encerro corretamente");


// Solicitar o nome, idade, peso para usuário
Console.Write("Digite o nome: ");
string nome = Console.ReadLine();
int idade = 0;
try
{
    //Solicitar a idade
    Console.WriteLine("Digite a Idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
}
catch(Exception e)
{
    Console.WriteLine("Idade não é um número inteiro valido");
}

double peso = 0;
try
{
    //Solicitar a peso
    Console.WriteLine("Digite o peso: ");
    peso = Convert.ToDouble(Console.ReadLine());

}
catch (Exception e)
{
    Console.WriteLine("Peso não é um valor real valido");
}
Console.WriteLine("Nome: " + nome + "\nIdade: " +idade + "\nPeso: " + peso);

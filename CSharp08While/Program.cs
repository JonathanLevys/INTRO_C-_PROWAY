//int indice = 0;
//while (indice <= 10)
//{
//    Console.WriteLine("...");

//    // Incrementar em 1 a variável indice
//    indice = indice + 1;
//}

//int indice = 0;
//int soma = 0;
//while (indice < 5)
//{
//    Console.Write("Digite um número: ");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    soma = soma + numero;

//    indice = indice + 1;
//}

//Console.WriteLine("Soma: " + soma);

int indice = 0;
int quantidadePessoasAdultas = 0;
int quantidadePessoasIdosas = 0;
int somaIdades = 0;

while (indice <= 3)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    somaIdades = somaIdades + idade;

    if ((idade > 18) && (idade < 60))
    {
        quantidadePessoasAdultas = quantidadePessoasAdultas + 1;
    }
    else if (idade >= 60)
    {
        quantidadePessoasIdosas = quantidadePessoasIdosas + 1;
    }

    indice = indice + 1;
}
double mediaIdades = somaIdades / 3;

Console.WriteLine(
    "Média das idades: " + mediaIdades +
    "\nQuantidade de pessoas adultas: " + quantidadePessoasAdultas +
    "\nQuantidade de pessoas adultas: " + quantidadePessoasIdosas);
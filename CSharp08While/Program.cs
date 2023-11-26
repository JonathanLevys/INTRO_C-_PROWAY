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

//int indice = 0;
//int quantidadePessoasAdultas = 0;
//int quantidadePessoasIdosas = 0;
//int somaIdades = 0;

//while (indice <= 3)
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine().Trim();

//    Console.Write("Idade: ");
//    int idade = Convert.ToInt32(Console.ReadLine());

//    somaIdades = somaIdades + idade;

//    if ((idade >= 18) && (idade < 60))
//    {
//        quantidadePessoasAdultas = quantidadePessoasAdultas + 1;
//    }
//    else if (idade >= 60)
//    {
//        quantidadePessoasIdosas = quantidadePessoasIdosas + 1;
//    }

//    indice = indice + 1;
//}
//double mediaIdades = somaIdades / 3;

//Console.WriteLine(
//    "Média das idades: " + mediaIdades +
//    "\nQuantidade de pessoas adultas: " + quantidadePessoasAdultas +
//    "\nQuantidade de pessoas adultas: " + quantidadePessoasIdosas);


//* Exercicio: solicitar os seguintes dados de 5 pessoas
//* -nome
//* -idade
//* -peso
//* -altura
//* Calcular o imc: peso / altura²
//* 
//* Apesentar no final a quantidade de pessoas de acordo com o imc:
//* -quantidade de pessoas abaixo do peso
//* -quantidade de pessoaspesp normal
//* -quantidade de pessoasexcesso de peso
//* -quantidade de pessoasobesidade i
//* -quantidade de pessoasobesidade II
//* -quantidade de pessoasobesidade III

//int indice = 0;

//while (indice < 5)
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine().Trim();

//    Console.Write("Idade: ");
//    int idade = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Peso: ");
//    double peso = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Altura: ");
//    double altura = Convert.ToDouble(Console.ReadLine());

//    double imc = peso / Math.Pow(altura, 2);

//    indice = indice + 1;
//}

int indice = 0;
double menorKmPorLitro = 99999999999;
double maiorQuantidadeKm = 0;
string modeloMenorQuantidadeKm = 0;

Console.Write("Infome a quantidade de carros que deseja validar: ");
int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

while(indice < quantidadeDesejada)

    Console.Write("Modelo: ");
    string modelo =  Console.ReadLine().Trim();

    Console.Write("Quilometros rodados: ");
    int quantidadeKm =  Convert.ToInt32(Console.ReadLine());

    Console.Write("Quilometros por litro: ");
    double KmPorLitro =  Convert.ToDouble(Console.ReadLine());
    
    if (quantidadeKm > maiorQuantidadeKm)
    {
        maiorQuantidadeKm = quantidadeKm;
        modeloMenorQuantidadeKm = modelo;
    }

    if (KmPorLitro < menorKmPorLitro)
    {
        menorKmPorLitro = KmPorLitro;
    modeloMenorQuantidadeKm = modelo;
    }

    Console.WriteLine("\n\n");
    indice = indice + 1;
}

Console.WriteLine(
    modeloMenorQuantidadeKm + "possui o menor consumo por litro: " + menorKmPorLitro +
    "\n" + modeloMenorQuantidadeKm + " possui a maior quilometragem rodados: " + maiorQuantidadeKm);
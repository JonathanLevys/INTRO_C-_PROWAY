string texto = "   Olá mundo, bem vindo ao C#   ";

Console.WriteLine("texto original: " + texto);

// Descobrir a quantidade de caracteres da string
int quantidadeCaracteres = texto.Length;
Console.WriteLine("Quantidade de caracteres: " +  quantidadeCaracteres);

//Remover espaços do começo
texto = texto.TrimStart();
// Remover espaços do fim
texto = texto.TrimEnd();

// Remover espaços do começo e do fim
texto = texto.Trim();
Console.WriteLine("Texto removido espaços: " + texto);
quantidadeCaracteres = texto.Length;
Console.WriteLine("Quantidade de caracteres: " + quantidadeCaracteres);



//  Transformar o texto em maiúscula
string textoCaixaAlta = texto.ToUpper();
//  Transformar o texto em minuscula
string textoCaixaBaixa = texto.ToLower();
Console.WriteLine("Texto em maísculo: " + textoCaixaAlta + "\nTexto em minúsculo: " + textoCaixaBaixa);  
// Verificar que texto começa com "Olá mundo"
if (texto.StartsWith("Olá mundo")) 
{
    Console.WriteLine("Começa com olá mundo"); 
} 
else 
{     
    Console.WriteLine("Não começa com olá mundo"); 
}

// Verificar que texto termina com ponto final
if (texto.EndsWith(".")) 
{     
    Console.WriteLine("Texto termina com ponto final"); 
}
else
{    
    Console.WriteLine("Texto não termina com ponto final");
}  

// Verificar que texto contém a palavra mundo 
if (texto.Contains("mundo")) 
{     
    Console.WriteLine("Contém a palavra mundo"); 
} 
else 
{     
    Console.WriteLine("Não contém a palavra mundo"); 
}

// Substituir termo "C#" po "CSharp"
texto = texto.Replace("C#", "CSharp");
Console.WriteLine("Texto substituido C# po Csharp: " + texto);

//                       0123456789
//Primeira posição de uma string sempre é o, depois 1,2,3.....
string nomeCompleto = "jonathan Levy";

//Descobrir o indice de caractere(es)
int indiceEspaco = nomeCompleto.IndexOf(" ");

string nome = nomeCompleto.Substring(0,indiceEspaco);
Console.WriteLine("\n\nnome: " + nome);

// Descobrir o ultimo indice de caracter
int indiceEspacoFim = nomeCompleto.LastIndexOf(" "); //8

// Apresentar o Ultimo nome "Levy"
Console.WriteLine("");
int quantidadeCaracteresUltimoNome = nomeCompleto.Length - indiceEspacoFim;
//string textoRemovidoEspacos = texto.Replace(" ", "");


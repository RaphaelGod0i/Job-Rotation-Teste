// See https://aka.ms/new-console-template for more information


// exercício 1

int Indice = 13;
int soma = 0;
int k = 0;

while (k < Indice)
{
    k += 1;

    soma += k;
}
Console.WriteLine("Exercício 1");
Console.WriteLine("");
Console.WriteLine("soma possui o valor de: " + soma);
Console.WriteLine("");
Console.WriteLine("Pressione enter para ir ao próximo exercício");

Console.ReadKey();

Console.Clear();

// exercício 2

int valorAnterior = 0;
int proximoFibonacci = 1;
Console.WriteLine("Exercício 2");
Console.WriteLine("");
Console.WriteLine("-----------------------------");
Console.WriteLine("      F I B O N A C C I      ");
Console.WriteLine("-----------------------------");

Console.Write("Informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

while (proximoFibonacci < numero)
{
    int proximoValor = valorAnterior + proximoFibonacci;
    valorAnterior = proximoFibonacci;
    proximoFibonacci = proximoValor;
}
if (proximoFibonacci == numero)
{
    Console.WriteLine($"O número {numero} pertence a sequência de Fibonacci");
}
else
{
    Console.WriteLine($"O número {numero} não pertence a sequência de fibonacci");
}
Console.WriteLine("");
Console.WriteLine("pressione enter para avançar ao próximo exercício");
Console.ReadLine();
Console.Clear();

//exercício 3
Console.WriteLine("Exercício 3");
Console.WriteLine("");
Console.WriteLine("Complete a lógica");
Console.WriteLine("a) 1, 3, 5, 7, _"); // some 2 número anterior
int a = 7;
Console.WriteLine("1, 3, 5, 7, some 2 número anterior ficando " + (a + 2));
Console.WriteLine("");
Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____"); // valor sendo multiplicado por 2
int b = 64;
Console.WriteLine("2, 4, 8, 16, 32, 64, o valor está sendo multiplicado por 2 o proximo será " + (b * 2));
Console.WriteLine("");
Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____"); //adicionando 2 a diferença do valor anterior
int c = 36;
Console.WriteLine(" 0, 1, 4, 9, 16, 25, 36, adicionando 2 a diferença do valor anterior ficaria " + (c + 13));
Console.WriteLine("d) 4, 16, 36, 64, __"); //adicionando 4 ao valor da diferença do valor anterior
int d = 64;
Console.WriteLine("4, 16, 36, 64, adicionando 4 ao valor da diferença do valor anterior " + (d + 36));
Console.WriteLine("");
Console.WriteLine("e) 1, 1, 2, 3, 5, 8, _"); // similiar a sequencia de Fibonacci some o anterior
int e = 8;
Console.WriteLine("1, 1, 2, 3, 5, 8," + (e + 5) + " está seguindo a sequencia de Fibonacci");
Console.WriteLine("");
Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, _"); // todos os numeros começam com a letra D
Console.WriteLine("2,10, 12, 16, 17, 18, 19, 200 pois todos os numeros começam com a letra D");
Console.WriteLine("");
Console.WriteLine("pressione enter para avançar ao próximo exercício");
Console.ReadLine();
Console.Clear();

//exercicio 4
Console.WriteLine("Exercício 4");
Console.WriteLine("");
Console.WriteLine("Ambos estarão a mesma distância de Ribeirão Preto uma vez que um está indo em direção a cidade e o outro na direção oposta");
Console.WriteLine("");
Console.WriteLine("pressione enter para avançar ao próximo exercício");
Console.ReadLine();
Console.Clear();

//exercicio 5

Console.WriteLine("Exercício 5");
Console.WriteLine("");
Console.Write("Informe a palavra a ser invertida: ");
string palavra = Console.ReadLine();

char[] caracteres = palavra.ToCharArray();
int tamanho = caracteres.Length;
int metade = tamanho / 2;

for (int i = 0; i < metade; i++)
{
    char temp = caracteres[i];
    caracteres[i] = caracteres[tamanho - i - 1];
    caracteres[tamanho - i - 1] = temp;
}

string palavraInvertida = new string(caracteres);

Console.WriteLine($"A palavra invertida é: {palavraInvertida}");
Console.ReadKey();


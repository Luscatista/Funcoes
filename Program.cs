//Função para somar

//int Somar()
//{
//    Console.WriteLine("Digite o promeiro numero"); 
//    int n1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Digite o segundo numero");
//    int n2 = int.Parse(Console.ReadLine());

//    return n1 + n2;
//}

//Console.WriteLine("Vamos somar!");
//Console.WriteLine($"O resultado da soma é: {Somar()}");
//Console.WriteLine();


//Console.WriteLine("Exercícios Básicos");
//Console.WriteLine("1. Função de Saudação");
//Console.WriteLine("Crie uma função chamada `Saudacao` que recebe um nome como parâmetro e exibe uma mensagem de boas-vindas.");
//Console.WriteLine();

void Saudacao(string nome)
{
    Console.WriteLine($"Olá, {nome}! Bem-vindo!!");
}
Console.WriteLine();
Saudacao("Tipoque");
Console.WriteLine();

Console.WriteLine("2. Função de Soma");
Console.WriteLine("Crie uma função chamada `Soma` que recebe dois números inteiros como parâmetros e retorna a soma deles.\r\n");
Console.WriteLine();

int Soma(int n1, int n2)
{
    return n1 + n2;
}

Console.WriteLine(Soma(5, 3));
Console.WriteLine();

Console.WriteLine("3. Função de Mensagem Simples");
Console.WriteLine("Crie uma função chamada `MostrarMensagem` que exibe uma mensagem fixa no console.");
Console.WriteLine();

void MostrarMensagem()
{
    Console.WriteLine("Este é um programa de C# com funções!\r\n");
}

MostrarMensagem();
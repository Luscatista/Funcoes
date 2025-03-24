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

Console.WriteLine("Exercícios Intermediários");
Console.WriteLine();
Console.WriteLine("4. Cálculo de Média");
Console.WriteLine("Crie uma função chamada `CalcularMedia` que recebe três notas como parâmetros e retorna a média delas.");
Console.WriteLine();

double CalcularMedia(double n1, double n2, double n3)
{
    double media = (n1 + n2 + n3) / 3;
    return media;
}

double media = CalcularMedia(7.5, 8.0, 6.5);
Console.WriteLine("Média: " + media);
Console.WriteLine();

Console.WriteLine("5. Verificação de Número Par");
Console.WriteLine("Crie uma função chamada `EhPar` que recebe um número inteiro e retorna `true` se ele for par e `false` se for ímpar.\r\n");
Console.WriteLine();

bool EhPar(int num)
{
    if(num % 2 == 0)
    {
        return true;
    }
    return false;
}

bool resultado = EhPar(10);
Console.WriteLine(resultado);
Console.WriteLine();

Console.WriteLine("6. Conversão de Temperatura");
Console.WriteLine("Crie uma função chamada `CelsiusParaFahrenheit` que recebe uma temperatura em graus Celsius e retorna o equivalente em Fahrenheit.\r\n");
Console.WriteLine();

double CelsiusParaFahrenheit(double n1)
{
    double fahrenheit = (n1 * 9 / 5) + 32;
    return fahrenheit;
}

double fahrenheit = CelsiusParaFahrenheit(25);
Console.WriteLine(fahrenheit);
Console.WriteLine();

Console.WriteLine("Exercícios Avançados");
Console.WriteLine();
Console.WriteLine("7. Contador de Vogais");
Console.WriteLine("Crie uma função chamada `ContarVogais` que recebe uma string e retorna a quantidade de vogais (a, e, i, o, u) na palavra.");
Console.WriteLine();


//Corrigir o exercicio abaixo
int ContarVogais(string palavra)
{
    int total = 0;
    foreach (var item in palavra)
    {
        if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
        {
            total++;
        }
    }
    return total;
}

int totalVogais = ContarVogais("Programação");
Console.WriteLine(totalVogais);
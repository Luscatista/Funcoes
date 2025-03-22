//Função para somar

int Somar()
{
    Console.WriteLine("Digite o promeiro numero"); 
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero");
    int n2 = int.Parse(Console.ReadLine());

    return n1 + n2;
}

Console.WriteLine("Vamos somar!");
Console.WriteLine($"O resultado da soma é: {Somar()}");
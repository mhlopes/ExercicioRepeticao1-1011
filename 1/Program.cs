Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

Tabuada(numero);

void Tabuada(int numero)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}
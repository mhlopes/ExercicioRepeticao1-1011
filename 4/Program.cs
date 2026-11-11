Console.Write("Digite um número inteiro: ");
int limite = int.Parse(Console.ReadLine());

Console.WriteLine($"Primos até {limite}:");

for (int candidato = 2; candidato <= limite; candidato++)
{
    bool primo = true;

    for (int divisor = 2; divisor < candidato; divisor++)
    {
        if (candidato % divisor == 0)
        {
            primo = false;
            break;
        }
    }

    if (primo)
    {
        Console.Write(candidato + " ");
    }
}

Console.WriteLine();
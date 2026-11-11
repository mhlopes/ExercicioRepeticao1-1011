bool Primo(int numero)
{
    if (numero <= 1)
        return false;

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
            return false;
    }
    return true;
}

void escrevePrimos(int numero)
{
    for (int i = 2; i <= numero; i++)
    {
        if (Primo(i))
            Console.Write(i + " ");
    }
}

Console.Write("digite um número:");
int entrada = int.Parse(Console.ReadLine());

escrevePrimos(entrada);
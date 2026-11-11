void imparCrescente(int numero)
{
    Console.WriteLine("Ímpares (crescente):");
    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}

void parDecrescente(int numero)
{
    Console.WriteLine("Pares (decrescente):");
    for (int i = numero; i >= 1; i--)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}


Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

imparCrescente(numero);
parDecrescente(numero);
void Fibonacci(int posicao)
{
    int anterior = 0;
    int atual = 1;
    for (int i = 1; i <= posicao; i++)
    {
        Console.Write(anterior + " ");
        int proximo = anterior + atual;
        anterior = atual;
        atual = proximo;
    }
    Console.WriteLine();
}

Console.Write("Digite até qual posição da seq fibonacci exibir: ");
int posicao = int.Parse(Console.ReadLine());


Fibonacci(posicao);
Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());
if (numero < 0 || numero > 20)
{
    Console.WriteLine("Não é possível calcular o fatorial de um número fora do intervalo [0, 20].");
}
else
{

    long fatorial = 1;

    int contador = numero;
    while (contador > 1)
    {
        fatorial = fatorial * contador;
        contador--;
    }

    Console.WriteLine($"{numero}! = {fatorial}");
}
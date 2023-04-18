Console.Clear();

int valor;

Console.Write("Digite um número: ");
valor = Int32.Parse(Console.ReadLine()!);

bool par = valor%2 == 0;

if (!par)
{
    Console.WriteLine($"\n{valor} é Impar");
}

else if (par)
{
    Console.WriteLine($"\n{valor} é Par");
}

Environment.Exit(-1); //Finaliza o Programa.
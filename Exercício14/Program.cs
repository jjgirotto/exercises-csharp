Console.Write("Quantos valores deseja digitar? ");
int qtde = Convert.ToInt32(Console.ReadLine());

void Insere(ref int[] fila, ref int fim, int valor)
{
    fila[fim] = valor;
    fim += 1;
}

int Remove(ref int[] fila, ref int inicio)
{
    inicio += 1;
    return (fila[inicio-1]);
}

bool EstaVazia(ref int inicio, ref int fim)
{
    return inicio == fim;
}

int i = 0;
int inicioGeral = 0, fimGeral = 0;
int[] filaGeral = new int[qtde];
while (i < qtde)
{
    Console.Write("Digite um número para a fila: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Insere(ref filaGeral, ref fimGeral, n);
    i++;
}
Console.Write("Digite um divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());
int[] filaMenores = new int[qtde];
int[] filaMaiores = new int[qtde];
int inicioMenores = 0, fimMenores = 0;
int inicioMaiores = 0, fimMaiores = 0;
for (int j = inicioGeral; j < fimGeral; j++)
{
    if (filaGeral[j] < divisor)
    {
        Insere(ref filaMenores, ref fimMenores, filaGeral[j]);
    }
    else if (filaGeral[j] > divisor)
    {
        Insere(ref filaMaiores, ref fimMaiores, filaGeral[j]);
    }
}

if ((fimMenores - inicioMenores) > 0)
{
    Console.WriteLine($"Há {fimMenores - inicioMenores} menor(es) que {divisor}: ");
    while (!EstaVazia(ref inicioMenores, ref fimMenores))
    {
        Console.WriteLine(Remove(ref filaMenores, ref inicioMenores));
    }
}
else
{
    Console.WriteLine("Não há valores menores que " + divisor + ".");
}

if ((fimMaiores - inicioMaiores) > 0)
{
    Console.WriteLine($"Há {fimMaiores - inicioMaiores} maior(es) que {divisor}: ");
    while (!EstaVazia(ref inicioMaiores, ref fimMaiores))
    {
        Console.WriteLine(Remove(ref filaMaiores, ref inicioMaiores));
    }
}
else
{
    Console.WriteLine("Não há valores maiores que " + divisor + ".");
}
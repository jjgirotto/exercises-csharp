int inicio, fim, qtde;
Console.Write("Digite a quantidade de números: ");
qtde = Convert.ToInt32(Console.ReadLine());
int[] fila = new int[qtde];
inicio = 0;
fim = 0;

void Insere(int valor)
{
    fila[fim] = valor;
    fim += 1;
}

int Remove()
{
    inicio += 1;
    return (fila[inicio - 1]);
}
bool EstaVazia()
{
    return inicio == fim;
}

int i, numero;
i = 0;
while (i < qtde)
{
   Console.Write("Digite o número: ");
   numero = Convert.ToInt32(Console.ReadLine());
   Insere(numero);
   i++;
}
int maior, menor, soma, media, n;
n = Remove();
maior = n;
menor = n;
soma = n;

while (!EstaVazia())
{
   n = Remove();
   if (n > maior)
      maior = n;
   if (n < menor)
      menor = n;
   soma += n;
}
media = soma / qtde;
Console.WriteLine("Maior valor = " + maior);
Console.WriteLine("Menor valor = " + menor);
Console.WriteLine("Média dos valores = " + media);
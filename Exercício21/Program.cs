tp_no topo = null;

tp_no Remove()
{
    tp_no no = topo;
    if (topo != null)
    {
        topo = topo.prox;
    }
    return no;
}

void Encadeada(int[] vetor, int index)
{
    if (index < vetor.Length)
    {
        tp_no no = new tp_no();
        no.valor = vetor[index];
        no.prox = topo;
        topo = no;       
        Encadeada(vetor, index + 1);
    }
}

void Exibir()
{
    tp_no aux = topo;
    int i = 1;
    Console.WriteLine("Números: ");
    while (aux != null)
    {
        Console.WriteLine(aux.valor);
        i++;
        aux = aux.prox;
    }
}

Console.Write("Quantos números deseja digitar? ");
int qtde = Convert.ToInt32(Console.ReadLine());
int[] vetor = new int[qtde];
for (int i = 0; i < qtde; i++)
{
    Console.Write($"Digite o {i+1} número: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
}
Encadeada(vetor, 0);
Exibir();
int maior, menor, soma, media, n;
n = Remove().valor;
maior = n;
menor = n;
soma = n;

for (int i = 1; i < vetor.Length; i++)
{
    n = Remove().valor;
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

class tp_no
{
    public int valor;
    public tp_no prox;
}

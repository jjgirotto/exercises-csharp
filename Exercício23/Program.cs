tpno inicio = null;
tpno fim = null;

void Insere(int valor)
{
    tpno no = new tpno();
    no.valor = valor;
    if (inicio == null)
    {
        inicio = no;
    }
    else
    {
        fim.prox = no;
    }
    fim = no;
}

tpno Remove()
{
    tpno no = inicio;   
    if (inicio != null)
    {
        inicio = inicio.prox;
    }
    if (inicio == null)
    {
        fim = null;
    }
    return no;
}

Console.Write("Quantos números deseja digitar? ");
int qtde = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < qtde; i++)
{
    Console.Write("Digite o valor desejado: ");
    int valor = Convert.ToInt32(Console.ReadLine());
    Insere(valor);
}
Console.WriteLine("Números da lista: ");
while (inicio != null)
{
    int numero = Remove().valor;
    Console.WriteLine(numero);
}
Console.WriteLine(fim.valor);
class tpno
{
    public int valor;
    public tpno prox;
}
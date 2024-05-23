tp_no topo = null;

void Insere(int valor)
{
    tp_no no = new tp_no();
    no.valor = valor;
    no.prox = topo;
    topo = no;
}

tp_no Remove()
{
    tp_no no = topo;
    if (topo != null)
    {
        topo = topo.prox;
    }
    return no;
}

Console.Write("Quantos valores deseja digitar? ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < n)
{
    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Insere(numero);
    Console.Write("Valor: ");
    Console.Write(Remove().valor + "\n");
    i++;
}

class tp_no
{
    public int valor;
    public tp_no prox;
}
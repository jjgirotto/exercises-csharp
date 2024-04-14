const int tamanhoFisico = 10; //se precisar mudar o tamanho do vetor, mudar somente nesta linha.
int[] fila = new int[tamanhoFisico];
int inicio = 0, fim = 0;

void Insere(int valor)
{
    fila[fim] = valor;
    fim = fim + 1;
}

int Remove()
{
    inicio = inicio + 1;
    return (fila[inicio - 1]);
}
bool EstaVazia()
{
    if (inicio == fim)
        return true;
    else
        return false;
}

bool EstaCheia()
{
    if (fim == tamanhoFisico)
        return true;
    else
        return false;
}

void ListaAvioes()
{
    int i;
    Console.WriteLine("Aviões da fila");
    for (i = inicio; i < fim; i++)
    {
        Console.WriteLine(fila[i]);
    }
}

int op = 0;
int numAviao;
while (op != 6)
{
    Console.WriteLine("MENU\n1. Adicionar um avião na fila\n2. Consultar quantidade de aviões na fila\n3. Autorizar a decolagem de um avião da fila\n4. Listar os números de todos os aviões na fila\n5. Consultar o número do primeiro avião da fila\n6. Sair");
    Console.Write("Digite sua opção: ");
    op = Convert.ToInt32(Console.ReadLine());
    if (op == 1)
    {
        Console.Write("Digite o número do avião: ");
        numAviao = Convert.ToInt32(Console.ReadLine());
        if (!EstaCheia())
        {
            Insere(numAviao);   
        }
        else
        {
            Console.WriteLine("Fila cheia!");
        }
    }
    else if (op == 2)
    {
        Console.WriteLine($"Tem {fim-inicio} avião(ões) na fila.");
    }
    else if (op == 3)
    {
        if (!EstaVazia())
        {
            numAviao = Remove();
            Console.WriteLine($"O avião {numAviao} pode usar a pista.");   
        }
    }
    else if (op == 4)
    {
        ListaAvioes();
    }
    else if (op == 5)
    {
        Console.WriteLine("O primeiro avião da fila é " + fila[inicio]);
    }
}

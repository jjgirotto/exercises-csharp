﻿// a nota é a chave, nome e email são valores
const int N = 5;
tp_pessoa[] vetor = new tp_pessoa[N];

int hash (int ch)
{
    return (ch % N);
}

void CriaPessoas() // instancia todos os 5 elementos do vetor (um nó em cada posição)
{
    for (int i=0; i < N; i++)
        vetor[i] = new tp_pessoa();
}

void InsereLinear(int nt, string nm, string em, ref int qc)
{
    int pos  = hash (nt);
    while (vetor[pos].nota != 0) // se já tiver valor na posição
    {
        pos++;                    // procura a próxima posição
        pos = pos % N;            // se for menor que 5, pos continua a mesma coisa, se for 5, vai voltar pra posição 0
        qc++; //conta 1 a cada colisão
    }
    vetor[pos].nota = nt; //adicionando os valores ao vetores
    vetor[pos].nome = nm;
    vetor[pos].email = em;
}

int Recuperar(int nt)
{
    int pos = hash(nt);
    int cont=0;   //contagem para verificar se já passou por todas as posições
    while (vetor[pos].nota != nt && cont<=N)
    {
        pos++;
        pos = pos % N;
        cont++;
    }
    if (cont <= N)  //se a contagem for menor do que o total é pq encontrou
        return pos;
    else
        return -1;
}

// Principal
int op = 1;
int nota, pos, QtdCol = 0;
string nome, email;
CriaPessoas();
while (op != 4)
{
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Inserir");
    Console.WriteLine("2 - Recuperar");
    Console.WriteLine("3 - Informar Qtd Colisões");
    Console.Write("Opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    if (op == 1)
    {
        Console.Write("Nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
        InsereLinear(nota, nome, email, ref QtdCol);
    }
    else if (op == 2)
    {
        Console.WriteLine("Digite uma nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        pos = Recuperar(nota);
        if (pos != -1)
        {
            Console.WriteLine("Nome: "+vetor[pos].nome);
            Console.WriteLine("Email: "+vetor[pos].email);
        }
        else
            Console.WriteLine("Nota não encontrada!");
    }
    else if (op == 3)
        Console.WriteLine("Qtd de Colisões: "+QtdCol);
}


class tp_pessoa
{
    public int nota;
    public string nome, email;
}
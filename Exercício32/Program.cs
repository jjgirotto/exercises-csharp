using System.ComponentModel;

const int N = 5;
tp_pessoa[] vetorSemTrat = new tp_pessoa[N];
tp_pessoa[] vetorTratLinear = new tp_pessoa[N];
tp_pessoa[] vetorTratEncadeada = new tp_pessoa[N];

int hash (int ch) //ok
{
    return (ch % N);
}

void CriaPessoas(ref tp_pessoa[]vetor) //ok 
{
    for (int i=0; i < N; i++)
        vetor[i] = new tp_pessoa();
}

void InsereSemTrat(int idade, string nome, string whats) //ok
{
    int pos = hash (idade);
    if (vetorSemTrat[pos].idade != 0)
    {
        Console.WriteLine($"A posição {pos} encontra-se ocupada. Tente novamente com outra idade.");
    }
    else
    {
        vetorSemTrat[pos].idade = idade;
        vetorSemTrat[pos].nome = nome;
        vetorSemTrat[pos].whats = whats;
    }
}

void InsereLinear(int idade, string nome, string whats) //ok
{
    int pos  = hash (idade);
    while (vetorTratLinear[pos].idade != 0) // se já tiver valor na posição
    {
        pos++;                    // procura a próxima posição
        pos = pos % N;            // se for menor que 5, pos continua a mesma coisa, se for 5, vai voltar pra posição 0
    }
    vetorTratLinear[pos].idade = idade; //adicionando os valores ao vetores
    vetorTratLinear[pos].nome = nome;
    vetorTratLinear[pos].whats = whats;
}

void InsereEncadeada(int idade, string nome, string whats)
{
    int pos = hash(idade);
    tp_pessoa novaPessoa = new tp_pessoa();
    novaPessoa.idade = idade;
    novaPessoa.nome = nome;
    novaPessoa.whats = whats;
    if (vetorTratEncadeada[pos] != null)
    {
        novaPessoa.prox = vetorTratEncadeada[pos];
    }
    vetorTratEncadeada[pos] = novaPessoa;
}

int Recuperar(int idade, tp_pessoa[]vetor) //ok
{
    int pos = hash(idade);
    int cont=0;   //contagem para verificar se já passou por todas as posições
    while (vetor[pos].idade != idade && cont<=N)
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

int RecuperarEncadeada(int idade)
{
    int pos = hash(idade);
    while (vetorTratEncadeada[pos] != null)
    {
        if (vetorTratEncadeada[pos].idade == idade)
        {
            return pos;
        } 
        vetorTratEncadeada[pos] = vetorTratEncadeada[pos].prox;
    }
    return -1;
}

void Relatar(tp_pessoa[]vetor) //ok
{
    int contador = 0;
    for (int i = 0; i < N; i++)
    {
        if (vetor[i].idade != 0)
        {
            Console.WriteLine($"Posição: {i} - Idade: {vetor[i].idade} - Nome: {vetor[i].nome} - WhatsApp: {vetor[i].whats}");
            contador ++;
        }
    }
    if (contador == 0)
    {
        Console.WriteLine("A lista está vazia.");
    }
}

void RelatarEncadeada()
{
    for (int i = 0; i < N; i++)
    {
        tp_pessoa aux = vetorTratEncadeada[i]; //pessoa temporária auxiliar
        if (aux.idade != 0)
        {
            while (aux.idade != 0)
            {
                Console.WriteLine($"Posição: {i} - Idade: {aux.idade} - Nome: {aux.nome} - Whatsapp: {aux.whats}");
                aux = aux.prox;
            }
        }
    }
}

// Principal
int opcaoHash = 1;
int op = 1;
int idade, pos;
string nome, whats;
CriaPessoas(ref vetorSemTrat);
CriaPessoas(ref vetorTratLinear);
CriaPessoas(ref vetorTratEncadeada);
while (opcaoHash != 4)
{
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Sem tratamento de colisão");
    Console.WriteLine("2 - Tratamento de colisão linear");
    Console.WriteLine("3 - Tratamento de colisão com lista encadeada");
    Console.Write("Opção desejada: ");
    opcaoHash = Convert.ToInt32(Console.ReadLine());
    if (opcaoHash == 1) // ok
    {
        Console.WriteLine("MENU - sem tratamento de colisão");
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Alterar");
        Console.WriteLine("3 - Relatar");
        Console.Write("Opção desejada: ");
        op = Convert.ToInt32(Console.ReadLine());
        if (op == 1)
        {
            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Whatsapp: ");
            whats = Console.ReadLine();
            InsereSemTrat(idade, nome, whats);
            Console.WriteLine("Valores inseridos.");
        }
        else if (op == 2)
        {
            Console.WriteLine("Digite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            pos = Recuperar(idade, vetorSemTrat);
            if (pos != -1)
            {
                Console.WriteLine("Nome: "+ vetorSemTrat[pos].nome);
                Console.WriteLine("Whatsapp: "+vetorSemTrat[pos].whats);
                Console.Write("Digite o nome para alteração: ");
                vetorSemTrat[pos].nome = Console.ReadLine();
                Console.Write("Digite o Whatsapp para alteração: ");
                vetorSemTrat[pos].whats = Console.ReadLine();               
                Console.WriteLine("Alterações realizadas.");
            }
            else
                Console.WriteLine("Idade não encontrada!");
        }
        else if (op == 3)
        {
            Console.WriteLine("Relatório de pessoas (vetor sem tratamento)");
            Relatar(vetorSemTrat);
        }
    }
    else if (opcaoHash == 2) //ok
    {
        Console.WriteLine("MENU - tratamento de colisão linear");
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Alterar");
        Console.WriteLine("3 - Relatar");
        Console.Write("Opção desejada: ");
        op = Convert.ToInt32(Console.ReadLine());
        if (op == 1)
        {
            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Whatsapp: ");
            whats = Console.ReadLine();
            InsereLinear(idade, nome, whats);
        }
        else if (op == 2)
        {
            Console.WriteLine("Digite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            pos = Recuperar(idade, vetorTratLinear);
            if (pos != -1)
            {
                Console.WriteLine("Nome: "+ vetorTratLinear[pos].nome);
                Console.WriteLine("Whatsapp: "+vetorTratLinear[pos].whats);
                Console.Write("Digite o nome para alteração: ");
                vetorTratLinear[pos].nome = Console.ReadLine();
                Console.Write("Digite o Whatsapp para alteração: ");
                vetorTratLinear[pos].whats = Console.ReadLine();
                
            }
            else
                Console.WriteLine("Idade não encontrada!");
        }
        else if (op == 3)
        {
            Console.WriteLine("Relatório de pessoas - vetor com tratamento linear");
            Relatar(vetorTratLinear);
        }
    }
    else if (opcaoHash == 3) //ok
    {
        Console.WriteLine("MENU - tratamento de colisão com lista encadeada");
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Alterar");
        Console.WriteLine("3 - Relatar");
        Console.Write("Opção desejada: ");
        op = Convert.ToInt32(Console.ReadLine());
        if (op == 1)
        {
            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Whatsapp: ");
            whats = Console.ReadLine();
            InsereEncadeada(idade, nome, whats);
        }
        else if (op == 2)
        {
            Console.WriteLine("Digite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            pos = RecuperarEncadeada(idade);
            if (pos != -1)
            {
                Console.WriteLine("Nome: "+ vetorTratEncadeada[pos].nome);
                Console.WriteLine("Whatsapp: "+vetorTratEncadeada[pos].whats);
                Console.Write("Digite o nome para alteração: ");
                vetorTratEncadeada[pos].nome = Console.ReadLine();
                Console.Write("Digite o Whatsapp para alteração: ");
                vetorTratEncadeada[pos].whats = Console.ReadLine();
                
            }
            else
                Console.WriteLine("Idade não encontrada!");
        }
        else if (op == 3)
        {
            Console.WriteLine("Relatório de pessoas - vetor com tratamento lista encadeada");
            RelatarEncadeada();
        }
    }
}
class tp_pessoa
{
    public int idade;
    public string nome, whats;
    public tp_pessoa prox;
}
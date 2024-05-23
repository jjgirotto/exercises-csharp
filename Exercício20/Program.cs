tpno lista = null;

void Insere(string nome, int idade, string whats)
{
    tpno no = new tpno();
    no.nome = nome;
    no.idade = idade;
    no.whats = whats;
    no.prox = lista;
    lista = no;
}

/*tpno Remove() //essa função remove apenas do topo
{
    tpno no = lista;
    if (lista != null)
    {
        lista = lista.prox;
    }
    return no;
}*/

void Consulta(string np, ref tpno atual, ref tpno anterior)
{
    atual = lista;
    anterior = null;
    while (atual != null && np != atual.nome)
    {
        anterior = atual;
        atual = atual.prox;
    }    
}

void Exibir()
{
    tpno aux = lista;
    Console.WriteLine("Relatório");
    int i = 1;
    while (aux != null)
    {
        Console.WriteLine("Registro " + i);
        Console.WriteLine("Nome: " + aux.nome);
        Console.WriteLine("Idade: " + aux.idade);
        Console.WriteLine("Whats: " + aux.whats);
        i++;
        aux = aux.prox;
    }
}

int op = 1;
string nome, nomeproc, whats;
int idade;
tpno anterior = null;
tpno atual = null;
while (op != 5)
{
    Console.WriteLine("MENU\n1- Incluir dados\n2- Alterar dados\n3 - Excluir dados\n4- Exibir dados\n5 - Sair");
    Console.Write("Digite a opção: ");
    op = Convert.ToInt32(Console.ReadLine());
    if (op == 1)
    {
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o Whatsapp: ");
        whats = Console.ReadLine();
        Insere(nome, idade, whats);
    }
    else if (op == 2)
    {
        Console.Write("Digite o nome para alteração de dados: ");
        nomeproc = Console.ReadLine();
        Consulta(nomeproc, ref atual, ref anterior);
        if (atual != null)
        {
            Console.WriteLine($"Dados atuais:\nIdade: {atual.idade}\nWhatsApp: {atual.whats}");
            Console.WriteLine("Novos dados: ");
            Console.Write("Nome: ");
            atual.nome = Console.ReadLine();
            Console.Write("Idade: ");
            atual.idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("WhatsApp: ");
            atual.whats = Console.ReadLine();
            Console.WriteLine("Dados alterados com sucesso!");
        }
        else
        {
            Console.WriteLine("Nome não encontrado!");
        }
    }
    else if (op == 3) //essa estrutura de remoção, remove de qualquer lugar da lista
    {
        Console.Write("Digite o nome para exclusão de dados: ");
        nomeproc = Console.ReadLine();
        Consulta(nomeproc, ref atual, ref anterior);
        if (atual != null)
        {
            if (atual == lista) //se for o primeiro nome
            {
                lista = atual.prox;
            }
            else if (atual.prox == null) //se for o último nome
            {
                anterior.prox = null;
            }
            else //se o nome estiver no meio
            {
                anterior.prox = atual.prox;
            }
            Console.WriteLine("Dados excluídos com sucesso!");
        }
        else
        {
            Console.WriteLine("Nome não encontrado!");
        }
    }
    else if (op == 4)
    {
        Exibir();
    }
}

class tpno
{
    public string nome;
    public int idade;
    public string whats;
    public tpno prox;
}
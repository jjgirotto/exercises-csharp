char[] pilha = new char[100];
int topo = 0;
bool validacao = true;

void Insere(char i)
{
    pilha[topo] = i;
    topo += 1;
}

bool EstaVazia()
{
    return topo == 0;
}

char Remove()
{
    topo -= 1;
    return (pilha[topo]);
}

Console.Write("Digite a expressão: ");
string expressao = Console.ReadLine();
int qtde = expressao.Length;
int i = 0;
char simbolo;
while (i < qtde)
{
    if (expressao[i] == '(' || expressao[i] == '[' || expressao[i] == '{')
    {
        Insere(expressao[i]);
    }
    else if (expressao[i] == ')' || expressao[i] == ']' || expressao[i] == '}')
    {
        if (!EstaVazia())
        {
            simbolo = Remove();
            if (simbolo == '(' && expressao[i] == ')' || simbolo == '[' && expressao[i] == ']' || simbolo == '{' && expressao[i] == '}')
            {
                validacao = true;
            }
            else
            {
                validacao = false;
                break;
            }
        }
        else
        {
            validacao = false;
            break;
        }
    }
    i++;
}


if (!EstaVazia())
{
    validacao = false;
}
if (validacao)
{
    Console.WriteLine("Expressão válida!");
}
else
{
    Console.WriteLine("Expressão inválida!");
}
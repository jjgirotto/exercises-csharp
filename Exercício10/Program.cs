using System;

char[] pilha = new char[200];
int topo = 0;

void Insere(char i)
{
    pilha[topo] = i;
    topo += 1;
}

bool EstaVazia()
{
    if (topo == 0)
        return true;
    else
        return false;
}

char Remove()
{
    topo = topo - 1;
    return (pilha[topo]);
}

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();
int qtdeL = frase.Length;
int i = 0;

while (i < qtdeL)
{
    while (i < qtdeL && frase[i] != ' ')
    {
        Insere(frase[i]);
        i++;
    }
    while (!EstaVazia())
    {
        char letra = Remove();
        Console.Write(letra);
    }
    Console.Write(' ');
    i++;
}
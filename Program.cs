void crescente(int nI, int nF)
{
    if (nI <= nF)
    {
        Console.WriteLine(nI);
        crescente(nI+1, nF);
    }
}

void decrescente(int nI, int nF)
{
    if (nI <= nF)
    {
        decrescente(nI+1, nF);
        Console.WriteLine(nI);
    }
}

void impares(int nI, int nF)
{
    if (nI <= nF)
    {
        if (nI % 2 != 0)
        {
            Console.WriteLine(nI);
        }
        impares(nI+1, nF);
    }
}

void somatorio(int nI, int nF, ref int soma)
{
    if (nI <= nF)
    {
        soma += nI;
        somatorio(nI+1, nF, ref soma);
    }
}

int somatorioProfessor(int nI, int nF)
{
    if (nI == nF)
    {
        return nI;
    }
    else
    {
        return somatorioProfessor(nI+1, nF) + nI;
    }
}

int somaVetor(int[] vetor, int iI, int iF)
{
    if (iI == iF)
    {
        return vetor[iI];
    }
    else
    {
        return somaVetor(vetor, iI+1, iF) + vetor[iI];
    }
}

int op = 1;
while (op != 3)
{
    Console.WriteLine("\nMenu principal\n1 - Função sem vetor\n2 - Função com vetor\n3 - Sair");
    Console.Write("Digite a opção: ");
    op = Convert.ToInt32(Console.ReadLine());
    if (op == 1)
    {
        Console.Write("Digite o número inicial: ");
        int nI = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o número final: ");
        int nF = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Menu secundário\n1 - Inteiros em ordem crescente\n2 - Inteiros em ordem decrescente\n3 - Ímpares\n4 - Somatório\n5 - Sair");
        Console.Write("Digite a opção: ");
        int op2 = Convert.ToInt32(Console.ReadLine());
        if (op2 == 1)
        {
            crescente(nI, nF);
        }
        else if (op2 == 2)
        {
            decrescente(nI, nF);
        }
        else if (op2 == 3)
        {
            impares(nI, nF);
        }
        else if (op2 == 4)
        {
            //int soma = 0;
            //somatorio(nI, nF, ref soma);
            //Console.WriteLine("A soma é " + soma);
            Console.WriteLine("A soma é de " + somatorioProfessor(nI, nF));
        }
    }
    if (op == 2)
    {
        int qtde, i;
        Console.Write("Quantos números deseja digitar? ");
        qtde = Convert.ToInt32(Console.ReadLine());
        int[] vetor;
        vetor = new int[qtde];
        i = 0;
        while (i < qtde)
        {
            Console.Write("Digite um número: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
            i += 1;
        }
        Console.WriteLine($"A soma é de {somaVetor(vetor, 0, qtde-1)}.");
    }
}
using System.Security.Cryptography.X509Certificates;

int potencia(int x, int expoente)
{
    if (expoente == 0)
    {
        return 1;
    }
    else
    {
        return x * potencia(x, expoente - 1);
    }
}

void cubos(int n, int i)
{
    if (i <= n)
    {
        Console.WriteLine($"{i}³ = " + i * i * i);
        cubos(n, i+1);
    }  
}

int calcularMDC(int x, int y)
{
    if (x == y)
    {
        return x;
    }
    else if (x < y)
    {
        return calcularMDC(y, x);
    }
    else
    {
        return calcularMDC(x-y, y);
    }
}

int fibonacciIterativa(int n)
{
    if (n <= 0)
        return 0;
    else if (n == 1)
        return 1;
    else
    {
        int nAnterior, nAtual;
        nAnterior = 0;
        nAtual = 1;
        for (int i = 2; i <= n; i++)
        {
            int nProximo;
            nProximo = nAnterior + nAtual;
            nAnterior = nAtual;
            nAtual = nProximo;
        }
        return nAtual;
    }
}

int fibonacciRecursiva(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    else
    {
        return fibonacciRecursiva(n-1) + fibonacciRecursiva(n-2);
    }
}

void conversao(int n)
{
    if (n / 2 != 0)
    {
        conversao(n/2);      
    }
    Console.Write(n%2);
}

int op = 1;
while (op !=6)
{
    Console.WriteLine("MENU\n1 - Realizar uma potência\n2 - Calcular cubo\n3 - Calcular MDC\n4 - Calcular Fibonacci\n5 - Conversão para binário\n6 - Sair");
    Console.Write("Digite uma opção: ");
    op = Convert.ToInt32(Console.ReadLine());
    if (op == 1)
    {
        int x, expoente;
        Console.Write("Digite um número (base): ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um número (potência): ");
        expoente = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{x} elevado a {expoente} é: {potencia(x, expoente)}");
    }
    else if (op == 2)
    {
       Console.Write("Digite um número: ");
       int n, i;
       i = 1;
       n = Convert.ToInt32(Console.ReadLine());
       cubos(n, i);
    }
    else if (op == 3)
    {
        int x, y;
        Console.Write("Digite um número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite outro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O MDC de {x} e {y} é: {calcularMDC(x,y)}");
    }
    else if (op == 4)
    {
        int n, op2;
        Console.WriteLine("1 - Calcular de forma iterativa\n2 - Calcular de forma recursiva");
        Console.Write("Digite a opção: ");
        op2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o n-ésimo número: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (op2 == 1)
        {
            Console.WriteLine($"O {n}º número é " + fibonacciIterativa(n));
        }
        else
        {
            Console.WriteLine($"O {n}º número é " + fibonacciRecursiva(n));
        }
    }
    else if (op == 5)
    {
        int n;
        Console.Write("Digite um número inteiro para converter: ");
        n = Convert.ToInt32(Console.ReadLine());
        conversao(n);
    }
}

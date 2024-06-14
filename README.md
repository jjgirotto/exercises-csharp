# exercises-csharp
Exercícios da disciplina de Estrutura de Dados.

# Exercício 1:
Faça um programa que apresente um menu inicial. Se o usuário escolher a opção 1, solicite um número inteiro inicial e um número inteiro final. O número final deve ser maior que o inicial. Em seguida apresente um segundo menu com as seguintes opções e faça uma função recursiva para cada opção desse segundo menu. Se o usuário escolher a opção 2 (do menu inicial), solicite vários números inteiros (armazene num vetor) e em seguida faça uma função recursiva que calcule o somatório dos números do vetor.

# Exercício 2-6:
- 2) Escreva uma função recursiva chamada potencia(x, y), que retorne a base x elevado ao expoente y.
- 3) Faça uma função recursiva para calcular cubos de números até o número indicado pelo usuário.
- 4) Baseado no algoritmo de Euclides, implemente uma função recursiva para determinar o máximo divisor comum (mdc) entre dois números inteiros x e y.
- 5) Seja fib(n) uma função que retorna o n-ésimo termo da série de Fibonacci, implemente uma versão recursiva e outra iterativa.
- 6) Defina uma função recursiva que converte um número inteiro para a base binária.

# Exercício 9:
Faça um programa que converta um número inteiro da base decimal para a base binária.

# Exercício 10:
Escreva um programa para conhecer uma frase e exibi-la com as palavras invertidas sem inverter a frase. Por exemplo, a frase “Eu faço ADS” deve sair “uE oçaf SDA”.

# Exercício 11:
Elabore um programa que verifica se uma dada expressão é válida em relação aos abre e fecha parênteses, colchetes e chaves. Exemplos:
 
a) a = b + (c -d) * (e – f)				- válida
b) b = [c – d)						- inválida
c) while (m < (n[8] + o)) { m = m + 1; }		- válida
d) for (i = 1; i <= tl; i++				- inválida

# Exercício 14:
Escreva um programa que tenha uma fila cujo valores indicam prioridade, quanto maior o valor, maior a prioridade.
Seu programa deve inserir vários valores numa fila e solicitar um valor divisor. Em seguida, o programa deve dividir a fila inicial em duas novas filas, uma fila com valores menores que o divisor (menor prioridade) e outra fila com os valores maiores que o divisor (maior prioridade).
Por fim, informe os valores das duas novas filas.

# Exercício 15:
Escreva um programa que insira vários números numa fila. Após a digitação dos números, seu programa deve removê-los da fila para encontrar o maior, o menor e a média aritmética dos números. Por fim, informe os resultados encontrados.

# Exercício 16:
Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. Os aviões são identificados pelos números digitados pelo usuário. Neste programa, o usuário deve ser capaz de realizar as seguintes operações:
a) Adicionar um avião na fila de espera para decolagem
b) Consultar a quantidade de aviões aguardando na fila
c) Autorizar a decolagem de um avião da fila
d) Listar os números de todos os aviões na fila
e) Consultar o número do primeiro avião da fila
Construa um menu principal para oferecer essas operações ao usuário.

# Exercício 19:
Faça uma implementação que construa uma lista encadeada. Seu programa deve inserir vários valores (digitados pelo usuário) na lista e em seguida removê-los. Após remover um elemento da lista, exiba o valor na tela. A forma e a quantidade de valores a serem inseridos e removidos fica a seu critério.

# Exercício 20:
Faça um programa que utilize lista encadeada e que tenha as opções a seguir. O nó deve conter os atributos: nome, idade, whats e prox.
a)	Incluir conforme apresentado em aulas
b)	Para alterar, consulte pelo nome. Se encontrar, exiba os valores atuais e permita a alteração. Caso não encontre, exiba mensagem de não encontrado.
c)	Para excluir, procure pelo nome. Se encontrar, exiba os valores atuais e permita a exclusão. Caso não encontre, exiba mensagem de não encontrado.
d)	Na opção exibir, exiba todos os registros.

# Exercício 21:
Faça um programa para o usuário digitar vários números, inclua-os num vetor. Em seguida, faça uma função recursiva que copie os números do vetor para uma lista encadeada. Após copiar os números do vetor para a lista, percorra a lista para encontrar o menor, o maior e a média dos números. Por fim, exiba o menor, o maior e a média dos números.

# Exercício 23:
Implemente a lógica de uma lista encadeada com o conceito de fila, ou seja, insira os nós no fim da lista e remova-os do início da lista. Utilize duas variáveis (inicio e fim) para controlar os acessos a lista.

# Exercício 31:
Implemente um programa que conte a quantidade de colisões ocorridas durante o processo de inserção. Utilize o tratamento de colisão linear. O vetor deve ser de um tipo abstrato de dado composto por nota, nome e email. A nota deve ser um número inteiro e corresponderá a chave.
O menu deve conter as seguintes opções: Inserir, Recuperar e Informar. Na opção recuperar, solicite a nota e caso encontre-a no vetor, exiba o nome e o email correspondente, caso contrário, exiba a mensagem de nota não encontrada. A opção informar, informa a quantidade de colisões ocorridas até o momento.

# Exercício 32:
Implemente um programa com as seguintes opções: Sem tratamento de colisão, Tratamento de colisão Linear e Tratamento de colisão com Lista Encadeada.
	Dentro de cada opção deve haver as funcionalidades: Inserir, Alterar e Relatar.
	O vetor deve ser do tipo abstrato de dado composto por idade, nome e whats. Serão necessários 3 vetores, um para cada tipo de tratamento de colisão.
Para inserir um novo registro, solicite a idade, nome e whats. Utilize a idade como chave.

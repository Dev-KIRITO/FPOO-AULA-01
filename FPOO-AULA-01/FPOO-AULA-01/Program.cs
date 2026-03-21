internal class Program
{
    private static void Main(string[] args)
    {
        // Comentario de linha única
        Console.WriteLine("Hello, World!"); // Imprime "Hello, World!" no console

        /* Comentário de múltiplas linhas
           Este é um exemplo de comentário
           que pode se estender por várias linhas. 
        */


        /* Tipos de Dados:
         * int: para números inteiros
         * double: para números decimais
         * string: para texto
         * bool: para valores booleanos (true/false)
        */

        // Declaração de variáveis
        // Sintaxe: tipo-da-variavel nome-da-variavel = valor-da-variavel;

        int idade = 25; // Variável do tipo inteiro
        string nome = "Alice"; // Variável do tipo string
        double altura = 1.75; // Variável do tipo double
        bool estudante = true; // Variável do tipo booleano

        // Imprimindo as variáveis no console
        Console.WriteLine(nome);

        // Concatenando texto e variáveis
        Console.WriteLine("Nome: " + nome);

        // Interpolação de strings (C# 6.0+)
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}m, Estudante: {estudante}");

        Console.WriteLine("");

        // Operadores aritméticos ( + , -, *, /, % )
        int a = 10;
        int b = 2;

        int soma = a + b; // 12
        int subtracao = a - b; // 8
        int multiplicacao = a * b; // 20
        int divisao = a / b; // 5
        int resto = a % b; // 0

        // Operadores de comparação ( == , != , > , < , >= (> =), <= (< =) )

        bool igual = (a == b); // false
        bool diferente = (a != b); // true 
        bool maior = (a > b); // true
        bool menor = (a < b); // false
        bool maiorOuIgual = (a >= b); // true
        bool menorOuIgual = (a <= b); // false


        // Operadores lógicos ( && , || , ! )

        Console.WriteLine("");

        // Comparar se uma pessoa é sexo masculino e tem 18 anos

        int idadePessoa = 20;
        string sexoPessoa = "Masculino";

        bool alistar = (sexoPessoa == "Masculino") && (idadePessoa >= 18); // false

        Console.WriteLine($"A pessoa está apta para o alistamento: {alistar}");


        // Exemplo de uso do operador lógico OR (||)

        idadePessoa = 17;
        sexoPessoa = "Masculino";

        alistar = (sexoPessoa == "Masculino") || (idadePessoa >= 18); // false

        Console.WriteLine($"A pessoa está apta para o alistamento: {alistar}");



        // Exemplo de uso do operador lógico NOT (!)

        // Verificar se a pessoa não é do sexo feminino
        sexoPessoa = "Masculino";

        bool feminino = !(sexoPessoa == "Feminino"); // true

        Console.WriteLine($"A pessoa é do sexo Feminino: {feminino}");

        Console.WriteLine("");

        /*************************************************************************************************/

        // Estruturas de controle de fluxo

        // Estrutura condicional if-else
        /* Sintaxe: 
         * if (condição)
         * {
         *   comandos a serem executados se a condição for verdadeira
         * } else {
         *   comandos a serem executados se a condição for falsa
         * }
         * */

        // Verificar se uma pessoa é maior de idade

        idade = 25;

        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        // Estrutura condicional if-else if-else (para múltiplas condições)

        // Verificar a faixa etária de uma pessoa

        idade = 7;
        if (idade >= 18)
        {
            Console.WriteLine("Adulto");
        }
        else if (idade >= 13)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Criança");
        }

        Console.WriteLine("");

        // Estrutura Condicional switch-case (para múltiplas condições com base em um valor específico)

        // Verificar o dia da semana com base em um número (1 a 7)

        int diaSemana = 9;

        switch (diaSemana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("Número inválido para dia da semana");
                break;
        }

        Console.WriteLine("");

        /************************************************************************************************/
        // Estruturas de repetição (loops)

        // Estrutura de repetição while (enquanto a condição for verdadeira)

        int contador = 1;
        while (contador <= 10)
        {

            Console.WriteLine($"Contador: {contador}");
            contador += 2;// Incrementa o contador em 1 (contador = contador + 1)
        }


        // Estrutura de repetição do-while (executa o bloco pelo menos uma vez e depois verifica a condição)
        contador = 0;
        do
        {
            Console.WriteLine($"Contador: {contador}");
            contador++; // Incrementa o contador em 1 (contador = contador + 1)
        } while (contador <= 10);
        Console.WriteLine("");
        // Estrutura de repetição for (para um número específico de iterações)

        // Imprimir os números de 1 a 10 usando o loop for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Contador (for): {i}");
        }
        Console.WriteLine("");


        // Estrutura de repetição foreach (para iterar sobre coleções, como arrays ou listas)
        // Criando um array de strings
        string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Melancia", "Maracuja" };

        foreach (string gaveta in frutas)
        {
            Console.WriteLine($"Fruta: {gaveta}");
        }

        Console.WriteLine("");

        /************************************************************************************************/

        // Metodos (funções que realizam uma tarefa específica e podem ser reutilizadas)
        int num1 = 5;
        int num2 = 1;
        Console.WriteLine($"A soma de {num1} + {num2} é: {Somar(num1, num2)}");

    }

    // Exemplo de método para calcular a soma de dois números

    static int Somar(int a, int b)
    {
        return a + b;
    }

}
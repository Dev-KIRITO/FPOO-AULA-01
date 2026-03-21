internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com collections");

        // 1.LIST
        // Criando uma lista de strings 
        List<string> frutas = new List<string>();

        // Adicionando elementos na lista
        frutas.Add("Maça");
        frutas.Add("Banana");
        frutas.Add("Morango");

        // Acessar elemento por Indece: 
        Console.WriteLine($"A primeira fruta da lista é: {frutas[0]}");

        // Alterando o elemento do Indice
        frutas[1] = "Maracujá";

        // Verificando o tamanho (quantidade) da lista
        Console.WriteLine($"Total de frutas: {frutas.Count}");

        // Removendo um elemento da lista
        frutas.Remove("Morangos");

        // Imprimindo (percorrendo) todos os itens da lista
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("=======================");

        // 2.Dictionary
        // Criando um DicionárioChave, valor
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Adicionar dados ao dicionario
        notas.Add("Ana", 9.5);
        notas.Add("Carlos", 7);
        notas.Add("Marcos", 4.5);
        // notas[João] = 2.7; Maneira diferente de escrever

        // Acessar um elemento pelo Indice
        Console.WriteLine($"A nota da Ana é: {notas["Ana"]}");

        // Verificando se a chave existe no dicionario (importante para evitarmos erros)
        if (!notas.ContainsKey("José"))
        {
            Console.WriteLine("O nome não está sistema");
        }

        // Percorrendo um dicionario
        Console.WriteLine("\nBoletim Escolar");
        foreach (KeyValuePair<string, double> aluno in notas)
        {
            Console.WriteLine($"Aluno: {aluno.Key}, Nota: {aluno.Value}");
        }

        Console.WriteLine("=======================");

        // 3. QUEUE
        // Criando uma fila de documentos (string)
        Queue<string> documentos = new Queue<string>();

        // "Enfileirando" itens (Enquete)
        documentos.Enqueue("Relatorio.Final.pdf");
        documentos.Enqueue("Foto_Aluno.jpg");
        documentos.Enqueue("Declaracao_Matricula.docx");

        // "Mostrar" o próximo elemento da fila (Peek)
        Console.WriteLine($"Próximo documento: {documentos.Peek()}");

        // "Desenfileirando" um elemento da fila (Dequeue)
        documentos.Dequeue();

        // Contar elementos da Fila
        Console.WriteLine($"Total de documentos na lista: {documentos.Count}");

        // Percorrendo todos os elementos da fila
        foreach (string doc in documentos)
        {
            Console.WriteLine($"Nome do arquivo: {doc}");
        }

        // Limpar todos elementos da fila 
        documentos.Clear();

        Console.WriteLine("=======================");

        // 4. STACK
        // Criando uma Pilha de favoritos (strings)

        Stack<string> favoritos = new Stack<string>();

        // Empilhando itens 
        favoritos.Push("www.google.com");
        favoritos.Push("git.hub.com");
        favoritos.Push("www.microsoft.com");

        //  Mostrar o Primeiro elemento da lista
        Console.WriteLine($"O primeiro da lista é: {favoritos.Peek()}");

        // Desempilhar (remover) da pilha
        favoritos.Pop();

        foreach (string site in favoritos)
        {
            Console.WriteLine(site);
        }

        // Apagar todos os itens da pilha
        favoritos.Clear();

        Console.WriteLine("=======================");

    }
}
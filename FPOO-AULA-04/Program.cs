using static Program;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Livro> biblioteca = new List<Livro>
        {
            new Livro { Titulo = "O Senhor dos Anéis", Autor = "Tolkien", Preco = 80.0, Ano = 1954 },
            new Livro { Titulo = "1984", Autor = "George Orwell", Preco = 45.0, Ano = 1954 },
            new Livro { Titulo = "Dom Casmurro", Autor = "Machado de Assis", Preco = 30.0, Ano = 1899 },
            new Livro { Titulo = "O Hobbit", Autor = "Tolkien", Preco = 55.0, Ano = 1937 },
            new Livro { Titulo = "Clean Code", Autor = "Robert Martin", Preco = 120.0, Ano = 2008 }
        };


        // 1 - Filtragem e Busca (Where)
        // Buscar os livros com Preco maior que 100

        var listaLivros = biblioteca.Where(l => l.Preco > 100).ToList();

        Console.WriteLine("\n================================================================================\n");
        // Exibe as Informações dos Livros
        foreach (var livro in listaLivros)
        {
            Console.WriteLine($"Livro: {livro.Titulo} | Autor: {livro.Autor} | Ano de Publicação: {livro.Ano} | Preço: {livro.Preco}");
        }


        // 2 - FirstOrDefault - First
        // O Primeiro livro do autor "Tolkien"

        var buscaLivro = biblioteca.FirstOrDefault(l => l.Autor == "Tolkien");
        Console.WriteLine("\n================================================================================\n");
        Console.WriteLine($"Livro: {buscaLivro.Titulo} | Autor: {buscaLivro.Autor} | Ano de Publicação: {buscaLivro.Ano} | Preço: {buscaLivro.Preco}");


        // Ordernação (OrderBy, ThenBy)
        // Ordenar Livros por Ano de publicação
        listaLivros = biblioteca.OrderBy(l => l.Ano).ThenBy(l => l.Titulo).ThenBy(l => l.Autor).ToList();

        // Exibe as Informações dos Livros
        Console.WriteLine("\n================================================================================\n");
        foreach (var livro in listaLivros)
        {
            Console.WriteLine($"Livro: {livro.Titulo} | Autor: {livro.Autor} | Ano de Publicação: {livro.Ano} | Preço: {livro.Preco}");
        }

        // Projeção e/ou Transformação

        var titulosFormatados = biblioteca.Select(l => $"{l.Titulo} ({l.Ano})");

        // Exibe as Informações dos Livros
        Console.WriteLine("\n================================================================================\n");
        foreach (var titulo in titulosFormatados)
        {
            Console.WriteLine(titulo.ToString());
        }

        // Agregações Matematicas
        double totalPatrimonio = biblioteca.Sum(l => l.Preco);
        Console.WriteLine("\n================================================================================\n");
        Console.WriteLine($"Total de Patrimonio: {totalPatrimonio}");

        double mediaPreco = biblioteca.Average(l => l.Preco);
        Console.WriteLine($"Media do Preço: {mediaPreco}");

        double maiorPreco = biblioteca.Max(l => l.Preco);
        double menorPreco = biblioteca.Min(l => l.Preco);
        Console.WriteLine($"Livro mais caro: {maiorPreco} | Livro mais barato: {menorPreco}");


        // Particionamento Skip() Take()
        // Pular um registro e tazer os proximos
        listaLivros = biblioteca.Skip(1).Take(2).ToList();

        // Exibe as Informações dos Livros
        Console.WriteLine("\n================================================================================\n");
        foreach (var livro in listaLivros)
        {
            Console.WriteLine($"Livro: {livro.Titulo} | Autor: {livro.Autor} | Ano de Publicação: {livro.Ano} | Preço: {livro.Preco}");
        }

        listaLivros = biblioteca.Where(l => l.Autor == "Tolkien")
                                .OrderBy(l => l.Titulo)
                                .Skip(1)
                                .ToList();

        Console.WriteLine("\n================================================================================\n");
        Console.WriteLine("******************************** Exceções ********************************");
        Console.WriteLine("\n================================================================================\n");

        try
        {
            int numero = int.Parse("abc");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Programa Finalizado com Sucesso");
        }

    }


    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }
        public int Ano { get; set; }
    }

}
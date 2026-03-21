internal class Program
{
    private string nome;

    private static void Main(string[] args)
    {
        // Exemplo de Atributo de Classe Console
        Console.BackgroundColor = ConsoleColor.Blue;

        // Exemplo de Metodo console 
        Console.WriteLine("Hello, World!");

        // Exemplo de metodo para ler uma entrada do usuario
        Console.WriteLine("Digite seu nome:");
        // string nome = Console.ReadLine();

        //Exibir o nome digitado pelo usuario
        //Console.WriteLine($"Olá, {nome}! Seja bem-vindo!");

        // Instanciar um objeto da classe Carro
        Carro meuCarro = new Carro(); // Criar um novo objeto do tipo Carro sem informações inicializadas

        // Atribuir valores aos atributos do objeto meuCarro
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2020;

        Carro novoCarro = new Carro();
        novoCarro.Marca = "Chevrolet";
        novoCarro.Modelo = "Celta";
        novoCarro.Ano = 2005;

        meuCarro.ExibirInformacoes();
        novoCarro.ExibirInformacoes();

        meuCarro.Ligar();
        novoCarro.Ligar();

        Carro carroInicializado = new Carro
        {
            Marca = "Honda",
            Modelo = "Civic",
            Ano = 2019

        };

        /********************************************/

        ContaBancaria conta = new ContaBancaria();
        //conta.Saldo = 1000
        conta.Depositar(200);

        /********************************************/

        Acessorio carroTeste = new Acessorio();
        carroTeste.Marca = "Volkswagen"; // Atributos da classe mãe (superclasse)
        carroTeste.Ano = 1966;
        carroTeste.Modelo = "Fusca";

        carroTeste.Portas = 2; // Atributos da classe filha (subclasse)
        carroTeste.CambioAutomatico = false;

        carroTeste.ExibirInformacoes();
    }

    // Criar uma classe para representar um carro
    public class Carro
    {
        // Atributos de classe Carro
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        // Método para exibir as informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

        public void Ligar()
        {
            Console.WriteLine($"O carro {Modelo} está ligado.");
        }
    }

    // Exemplo de encapsulamento: Classe ContaBancária
    public class ContaBancaria
    {
        // Atributo privado: Ninguém fora da classe pode alterar
        private double Saldo;
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito de " + valor + " realizado com sucesso!");
        }
    }

    // Exemplo de Herança: A classe Acessorios irá herdar a classe Carro
    public class Acessorio : Carro
    {
        public int Portas;
        public bool CambioAutomatico;
    }
}
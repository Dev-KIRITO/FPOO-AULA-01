using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext // Herda de IdentityDbContext para incluir as funcionalidades de autenticação e autorização

    {
        // Sobrescreve o construtor para aceitar as opções de configuração do DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define um DbSet para a entidade Cliente e todas a entidades que se tornarão tabelas no banco de dados, permitindo que o Entity Framework Core gerencie as operações de banco de dados relacionadas à entidade.

        public DbSet<Cliente> Clientes { get; set; } // Propriedade para acessar a tabela de clientes no banco de dados, permitindo realizar operações como consultas, inserções, atualizações e exclusões de clientes utilizando o Entity Framework Core.

    }
}

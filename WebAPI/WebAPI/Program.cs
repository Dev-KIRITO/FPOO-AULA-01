using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using WebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicionar os serviços ao contêiner.

// 1. Adicionar o serviço de controladores
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// 2. Configurar o Entity Framework Core para usar o SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 3. Configurção de CORS para permitir requisições de origens específicas (opcional, mas recomendado para APIs)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// 4. Adicionar o Identity para autenticação e autorização (opcional, mas recomendado para APIs seguras)
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// 5. Configurar a autenticação e autorização (opcional, mas recomendado para APIs seguras)
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();

app.MapOpenApi(); // Mapeia as rotas para os endpoints de documentação OpenAPI, permitindo que os clientes da API possam acessar a documentação interativa da API, facilitando o entendimento dos recursos disponíveis, os parâmetros esperados e as respostas retornadas pela API, além de fornecer uma interface amigável para testar os endpoints diretamente a partir da documentação.

app.MapScalarApiReference(options =>
{
    options.WithTitle("WebAPI - Matheus Conceicion")
           .WithTheme(ScalarTheme.Moon);
}); // Mapeia as rotas para os endpoints de referência da API usando o Scalar, permitindo que os clientes da API possam acessar uma interface de referência interativa e personalizada para explorar os recursos da API, facilitando o entendimento dos endpoints disponíveis, os parâmetros esperados e as respostas retornadas pela API, além de fornecer uma experiência de usuário aprimorada para a documentação da API.

app.MapGet("/", () => Results.Redirect("/scalar"));

app.UseHttpsRedirection(); // Redireciona todas as requisições HTTP para HTTPS para garantir a segurança da comunicação

app.UseAuthentication(); // Habilita a autenticação para proteger as rotas da API, garantindo que apenas usuários autenticados possam acessar os recursos protegidos
app.UseAuthorization(); // Habilita a autorização para controlar o acesso aos recursos da API com base nas permissões do usuário, garantindo que apenas usuários autorizados possam acessar determinados recursos ou realizar certas ações

app.UseCors("AllowAll"); // Habilita o CORS com a política "AllowAll" para permitir requisições de qualquer origem, método e cabeçalho, facilitando o desenvolvimento e testes da API, mas deve ser configurado adequadamente para produção para evitar riscos de segurança

app.MapIdentityApi<IdentityUser>(); // Mapeia as rotas para os endpoints de autenticação e gerenciamento de usuários fornecidos pelo Identity, permitindo que os clientes da API possam se registrar, fazer login, gerenciar suas contas e realizar outras operações relacionadas à autenticação e autorização de forma fácil e integrada com o sistema de identidade do ASP.NET Core.
app.MapControllers(); // Mapeia as rotas para os controladores da API, permitindo que as requisições sejam direcionadas para os métodos apropriados nos controladores, facilitando a organização e a estruturação da lógica de negócios da API em diferentes controladores e ações.

app.Run(); // Inicia a aplicação, permitindo que ela comece a ouvir as requisições HTTP e a processá-las de acordo com as rotas e os controladores definidos, tornando a API funcional e acessível para os clientes.
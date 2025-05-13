using minhaSegundaAPI.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGetRoutes(); // Chama as rotas que você colocou no outro arquivo

app.Run();


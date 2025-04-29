var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//PRIMEIRA ROTA
app.MapGet("/", () => "Semana que vem voces deverao me entregar uma atividade");
//SEGUNDA ROTA
app.MapGet("/sobre", () => "Eu sou o Gustavo, aluno da UP");
//TERCEIRA ROTA
app.MapGet("/menu", () => "Eu sou o Gustavo, aluno da UP - TERCEIRA ROTA");
//QUARTA ROTA
app.MapGet("/sla", () => "Eu sou o Gustavo, aluno da UP - QUARTA ROTA");
//QUINTA ROTA
app.MapGet("data", () => $"A data de hoje é: {DateTime.Now.ToString("dd/MM/yyyy")}");
//SEXTA ROTA
app.MapGet("hora", () => $"A hora de hoje é: {DateTime.Now.ToString("HH:mm:ss")}");

app.Run();

using minhaSegundaAPI.Models;

namespace minhaSegundaAPI.Routes
{
    public static class RotaGet
    {
        public static void MapGetRoutes(this WebApplication app)
        {
            var livros = new List<Livro>
            {
                new Livro { Id = 1, Titulo = "Harry potter e Pedra filosofal", Autor = "J.K. Rolling", AnoPublicacao = 2000 },
                new Livro { Id = 2, Titulo = "Harry potter e a Camera Secreta", Autor = "J.K. Rolling", AnoPublicacao = 2001 }
            };

            app.MapGet("/api/livros", () => livros);

            app.MapGet("/api/livros/{id}", (int id) =>
            {
                var livro = livros.FirstOrDefault(l => l.Id == id);
                return livro is not null ? Results.Ok(livro) : Results.NotFound();
            });
        }
    }
}
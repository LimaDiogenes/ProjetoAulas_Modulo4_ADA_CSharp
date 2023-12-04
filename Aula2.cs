namespace ProjetoAulas
{
    public static class Aula2
    {
        public static void MapAula2Endpoints(this WebApplication app)
        {
            app.MapGet("/aula_2/generics", () => { return "Aula2"; });
        }
    }
}

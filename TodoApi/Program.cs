using TodoApi.DAL;
using TodoApi.DAL.Interface;
using TodoApi.Model.Interface;

namespace TodoApi
{

    class Program
    {
        static void Main(string[] args)
        {
            ITodoDAL dal = DALFactory.GetTodoDAL();

        }

        static void StartWebServce(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            WebApplication app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.MapPost("/items", () => "post");

            app.MapPut("/items", () => "put");

            app.MapDelete("/items", () => "delete");

            app.Run();
        }
    }
}
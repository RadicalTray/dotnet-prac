using Microsoft.OpenApi.Models;

internal class Program {
    private static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c => {
            c.SwaggerDoc(
                "v1",
                new OpenApiInfo {
                    Title = "Todo API",
                    Description = "Keep track of your tasks",
                    Version = "v1"
                }
            );
        });

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");
        app.MapGet("/pizzas", () => "GET OUT");

        if (app.Environment.IsDevelopment()) {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
            });
        }

        app.Run();
    }
}
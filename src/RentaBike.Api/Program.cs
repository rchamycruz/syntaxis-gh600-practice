var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/saludar", () => Results.Text("Hola desde RentaBike"));

app.Run();

public partial class Program
{
}

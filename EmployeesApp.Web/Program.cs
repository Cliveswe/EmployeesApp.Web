namespace EmployeesApp.Web;

public class Program
{
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");
        //Hej fråan Philippe

        app.Run();
    }
}
//Hej from Ghassan
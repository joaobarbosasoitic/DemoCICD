var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//  //asdasd adasd
app.MapGet("/", () => "Hello CI/CD!");
app.MapGet("/soma/{a:int}/{b:int}", (int a, int b) => a + b);

app.Run();


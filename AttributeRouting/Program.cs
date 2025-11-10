var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //step1
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();//step 2 then go to the controller

app.Run();

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
///
var conn = builder.Configuration.GetConnectionString("SampleDbConnection");
//builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApiDbContext>(opt => opt.UseNpgsql(conn));
///

app.Run();

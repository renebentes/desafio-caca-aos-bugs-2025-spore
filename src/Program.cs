using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddDbContext<AppDbContext>(options => options.UseSqlite());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

using MongoDB;
using Pastebin.DataAccess;
using Pastebin.DataAccessContract;
using Pastebin.Service;
using Pastebin.ServiceContract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<MongoDbContext>();
builder.Services.AddScoped<IPasteDataAccess, PasteDataAccess>();
builder.Services.AddScoped<IPasteService, PasteService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

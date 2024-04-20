using web_api.Contracts;
using web_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IShoppingCartService, ShoppingCartService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using SimpleCommerce.API.Expansions.Extensions;
using SimpleCommerce.Application.Expansions.Extensions;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Infrastructure.Expansions.Extensions;
using TransportGlobal.API.Extensions.Registrations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Extend services with application layer
builder.Services.AddApplicationLayer(builder.Configuration);

// Extend services with infrastructure layer
builder.Services.AddInfrastructureLayer(builder.Configuration);

// Extend services with api layer
builder.Services.AddAPILayer(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Extend app with api layer
app.AddAPILayer();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

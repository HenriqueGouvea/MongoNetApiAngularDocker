using Store.API.Application.Endpoints;
using Store.API.Application.Exceptions;
using Store.API.Domain.Services;
using Store.API.Domain.Services.Interfaces;
using Store.API.Repository;
using Store.API.Repository.Context;
using Store.API.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IStoreContext, StoreContext>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(new [] { "http://localhost:4200", "https://localhost:4200" })
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();
app.AddEndpointGroups();
app.Run();
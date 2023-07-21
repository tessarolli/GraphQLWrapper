using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddHttpClient("StarWars", c => c.BaseAddress = new Uri("https://rickandmortyapi.com/graphql"));

    builder.Services
        .AddGraphQLServer()
        .AddRemoteSchema("StarWars");
}

var app = builder.Build();
{
    app.MapGraphQL();

    app.Run();
}
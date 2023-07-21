using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddHttpClient("RickAndMorty", c => c.BaseAddress = new Uri("https://rickandmortyapi.com/graphql"));

    builder.Services
        .AddGraphQLServer()
        .AddRemoteSchema("RickAndMorty");
}

var app = builder.Build();
{
    app.MapGraphQL();

    app.Run();
}
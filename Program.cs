using hot_chocolate_v1_federations;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddApolloFederation(FederationVersion.Federation10)
    .AddQueryType<Query>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => "Hi!");
app.MapGraphQL();

app.Run();
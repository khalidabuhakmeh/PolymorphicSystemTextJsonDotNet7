using Polymorphic.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new Person[] {
    new Doctor("Doogie Howser, M.D.", "Pharmaceutical Chemistry"),
    new Gamer("Justin Wong", "Marvel Vs. Capcom 2"),
    new Programmer("Grace Hopper", "FLOW-MATIC"),
    new Wrestler("The Rock", "The People's Elbow")
});

app.Run();


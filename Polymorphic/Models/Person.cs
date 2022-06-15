using Polymorphic.Generator;

namespace Polymorphic.Models;

/* source generator stuff will happen */
[JsonDerivedTypes] public partial record Person(string Name);

// it's cool, go ahead add more
public record Programmer(string Name, string Language) : Person(Name);
public record Wrestler(string Name, string FinishingMove) : Person(Name);
public record Doctor(string Name, string Specialty): Person(Name);
public record Gamer(string Name, string Game): Person(Name);
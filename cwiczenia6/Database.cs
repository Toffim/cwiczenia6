using cwiczenia6.Models;

namespace cwiczenia6;

public class Database
{
    public static List<Test> Tests = new List<Test>()
    {
        new Test() { Id = 1, Name = "Test1" },
        new Test() { Id = 2, Name = "Test2" },
        new Test() { Id = 3, Name = "Test3" }
    };

    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { Id = Animals.GenerateId(), Name = "Bruno", Category = "Dogs", Mass = 40.0, ColorFur = "Black-Grey" },
        new Animal() { Name = "Garfield", Category = "Cats", Mass = 20.0, ColorFur = "Orange" }
    };
}
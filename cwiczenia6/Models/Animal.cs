namespace cwiczenia6.Models;

public class Animal
{
    private static int animalId = 1;
    public static int AnimalId { get => animalId; }

    public int GenerateId()
    {
        return animalId++;
    }

    public int Id { get; private set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Mass { get; set; }
    public string ColorFur { get; set; }
}
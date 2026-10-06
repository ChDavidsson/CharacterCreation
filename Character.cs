namespace CharacterCreation;

public class Character
{
    // Klass Character med Name, Level, Power.
    public string Name;
    public int Level;
    public int Power;
    // ReadInfo() tar in namn, level (int), power (int).
    public void ReadInfo()
    {
        Console.WriteLine("What is your character name?");
        Name = Console.ReadLine()!;
        Console.WriteLine("What is your character level?");
        Level = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your character power?");
        Power = Convert.ToInt32(Console.ReadLine());
        
    }
    // ShowStats() skriver ut karaktären snyggt.
    public void ShowStats()
    {
        Console.WriteLine($"Character name:{Name}\n Level: {Level} \n Power: {Power}");
    }
    // Lägg till en metod CalculateStrength() som returnerar Level * Power.
    public void CalculateStrength()
    {
        int TotalStrength = Level * Power;
        Console.WriteLine($"Combined strength: {TotalStrength}");
    }
}

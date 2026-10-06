namespace CharacterCreation;

class Program
{
    static void Main(string[] args)
    {
        // 👉 Låt två karaktärer skapas och jämför deras styrka 
    // (utan if än — bara skriv ut båda styrkorna).
    Character character1 = new Character();
    character1.ReadInfo();

    Character character2 = new Character();
    character2.ReadInfo();

    Console.WriteLine($"{character1.Name} stats:");
    character1.ShowStats();
    Console.WriteLine($"{character1.Name} strength:");
    character1.CalculateStrength();
    Console.WriteLine($"{character2.Name} stats:");
    character2.ShowStats(); 
    Console.WriteLine($"{character2.Name} strength:");
    character2.CalculateStrength();
    }
}

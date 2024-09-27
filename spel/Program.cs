
int heroHp = 100;
int villainHp = 100;
Console.WriteLine("p1 skriv ditt namn");
string heroName = Console.ReadLine();
Console.WriteLine("p2 skriv ditt namn");
string villainName = Console.ReadLine();

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}\n");

  int heroDamage = generator.Next(20);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} vann!");
}
else
{
  Console.WriteLine($"{heroName} vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
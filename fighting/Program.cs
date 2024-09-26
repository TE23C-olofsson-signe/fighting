
int heroHp= 400; 
int villainHp= 100; 

// string heroname = Console.ReadLine(); 

string heroName = "Tonks";
string villainName = "Voldermort"; 



while(heroHp >0 && villainHp >0)
{
    Console.WriteLine("\n----- ===== NY RUNDA ===== -----"); 
    Console.WriteLine($"{heroName}: {heroHp} {villainName}: {villainHp}\n");

      int heroDamage = Random.Shared.Next(20);
      villainHp -= heroDamage;
      villainHp = Math.Max(0, heroHp); 
      Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

      int villainDamage = Random.Shared.Next(20); 
      heroHp -= villainDamage;
      heroHp = Math.Max(0, heroHp);
      Console.WriteLine($"{villainName}: gör {villainDamage} skada på {heroName}");
     
      Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
      Console.ReadKey(); 
}

Console.WriteLine("\n----- ===== Striden är slut ===== -----");

if(heroHp == 0 && villainHp ==0)
{
    Console.WriteLine("OAVGJORT");
}
else if(heroHp == 0)
{
    Console.WriteLine($"{villainName} vann!");
}
else{
    Console.WriteLine($"{heroName} vann!");
}

Console.WriteLine("tryk på valfri knapp för att avsluta.");
Console.ReadKey(); 

//Console.WriteLine("skriv ditt namn");
//string name = Console.ReadLine(); 

//while (name.Length<.3)
//{
//    Console.WriteLine("Namn ditt dum huvud");
 //   name = Console.ReadLine();
//}

//Console.WriteLine($"hej {name}!");
Console.ReadLine(); 
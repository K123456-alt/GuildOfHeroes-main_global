//Probe.Run();


// Game y = new Game("y", 50);
// Game n = new Game("n", 40);
// Game a = new Game("a", 32);

// Console.WriteLine(">>> Герой 1 <<<");
// Console.WriteLine($"z: {y.Z}");
// Console.WriteLine($"h: {y.H}");
// Console.WriteLine($"o: {y.O}");
// Console.WriteLine($"t: {y.T}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"z: {n.Z}");
// Console.WriteLine($"h: {n.H}");
// Console.WriteLine($"o: {n.O}");
// Console.WriteLine($"t: {n.T}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"z: {a.Z}");
// Console.WriteLine($"h: {a.H}");
// Console.WriteLine($"o: {a.O}");
// Console.WriteLine($"t: {a.T}");

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }

// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());

// "Game.cs" !!!!
// Game game1 = new Game("Ведьмак 3", "RPG", 2015, 9.8);
// Game game2 = new Game("Minecraft", "Sandbox", 2011, 9.5);
// Game game3 = new Game("DOOM Eternal", "Shooter", 2020, 8.7);

// List<Game> games = new List<Game>();
// games.Add(game1);
// games.Add(game2);
// games.Add(game3);

// Console.WriteLine($">>> Каталог игр <<<");
// Console.WriteLine($"Игр в списке: {games.Count}");

// if (games.Count > 0) {
//     Console.WriteLine($"Первая: {games[0].Title}");
//     Console.WriteLine($"Последняя: {games[games.Count - 1].Title}");
// }

// Console.WriteLine();
// foreach (Game game in games) {
//     Console.WriteLine($"{game.Title} ({game.Genre}, {game.ReleaseYear}) — рейтинг {game.Rating}, часов: {game.HoursPlayed}");
//     Console.WriteLine();
// }

// Game game4 = new Game("Hades", "Roguelike", 2020, 9.3);
// games.Add(game4);

// Console.WriteLine($"После добавления: {games.Count}");
// foreach (Game game in games) {
//     Console.WriteLine($"{game.Title} - часов: {game.HoursPlayed}");
// }

// int highRatedCount = 0;
// foreach (Game game in games) {
//     if (game.Rating >= 9.5) {
//         highRatedCount += 1;
//     }
// }
// Console.WriteLine($"Игр с рейтингом от 9.5: {highRatedCount}");

// game1.AddHours(25);

// Console.WriteLine($"game1 через переменную: {game1.HoursPlayed}");
// Console.WriteLine($"game1 через список: {games[0].HoursPlayed}");

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);


Guild guild = new Guild("Гильдия героев");

guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);


Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

if (guild.Heroes.Count > 0)
{
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes)
{
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;
foreach (Hero hero in guild.Heroes)
{
    if (hero.Health >= 120)
    {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0)
{
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes)
    {
        if (hero.Health > strongest.Health)
        {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

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

// GameCatalog catalog = new GameCatalog("Каталог игр");

// Console.WriteLine($">>> {catalog.Name} <<<");
// Console.WriteLine($"Игр до добавления: {catalog.GameCount}");

// Console.WriteLine($"Принят Ведьмак 3: {catalog.AddGame(game1)}");
// Console.WriteLine($"Принят Minecraft: {catalog.AddGame(game2)}");
// Console.WriteLine($"Принят DOOM Eternal: {catalog.AddGame(game3)}");

// Game duplicate = new Game(" ведьмак 3 ", "RPG", 2015, 9.8);
// Console.WriteLine($"Повтор ведьмак 3 принят: {catalog.AddGame(duplicate)}");

// Game? found = catalog.FindByTitle(" MINECRAFT ");
// if (found != null) {
//     Console.WriteLine($"Найден: {found.Title}");
// } else {
//     Console.WriteLine("Minecraft не найден.");
// }

// Game? notFound = catalog.FindByTitle("Hades");
// if (notFound != null) {
//     Console.WriteLine($"Найден: {notFound.Title}");
// } else {
//     Console.WriteLine("Hades не найден.");
// }

// Console.WriteLine($"Удалён Minecraft: {catalog.RemoveGame("minecraft")}");
// Console.WriteLine($"Удалён отсутствующий Hades: {catalog.RemoveGame("Hades")}");
// Console.WriteLine($"Игр после изменений: {catalog.GameCount}");

// Console.WriteLine($"Игр с рейтингом от 9.5: {catalog.CountHighlyRated(9.5)}");

// game1.AddHours(25);
// List<Game> games = catalog.GetGames();
// foreach (Game game in games) {
//     if (game.Title == "Ведьмак 3") {
//         Console.WriteLine($"Ведьмак 3 через каталог: {game.HoursPlayed} часов");
//     }
// }

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

Guild guild = new Guild("Гильдия героев");

guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);


List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0)
{
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members)
{
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}
Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null)
{
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
}
else
{
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}
Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

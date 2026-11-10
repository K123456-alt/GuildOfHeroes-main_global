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

// GameCatalog catalog = new GameCatalog("Каталог игр");
// catalog.AddGame(game1);
// catalog.AddGame(game2);

// Console.WriteLine($">>> {catalog.Name}: {catalog.GameCount} игр <<<");

// GameSession session = new GameSession(1, "Вечерняя сессия", 25);

// Console.WriteLine($"Старт для Ведьмака: {session.TryStart(game1)}");
// Console.WriteLine($"Старт повторно: {session.TryStart(game2)}");
// Game? current = session.AssignedGame;
// if (current != null) {
//     Console.WriteLine($"Игра в сессии: {current.Title}");
// }
// Console.WriteLine($"Ведьмак 3 до завершения: {game1.HoursPlayed} часов");

// Console.WriteLine($"Завершение: {session.TryFinish()}");
// Console.WriteLine($"Ведьмак 3 после завершения: {game1.HoursPlayed} часов");

// Console.WriteLine($"Повторное завершение: {session.TryFinish()}");
// Console.WriteLine($"Ведьмак 3 после повтора: {game1.HoursPlayed} часов");

// Game? found = catalog.FindByTitle(" ведьмак 3 ");
// if (found != null) {
//     Console.WriteLine($"Через каталог: {found.Title} — {found.HoursPlayed} часов");
// } else {
//     Console.WriteLine("Ведьмак 3 не найден в каталоге.");
// }

Console.WriteLine();
// Console.WriteLine(session.GetInfo());
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
Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();
QuestBoard board = new QuestBoard(guild);

Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");



Guild traceGuild = new Guild("Трассировка");
Hero anya = new Hero("Аня", 120);
traceGuild.AddHero(anya);

QuestBoard traceBoard = new QuestBoard(traceGuild);
Quest first = new Quest(1, "Первое", 100, 10);
Quest second = new Quest(2, "Второе", 130, 20);
traceBoard.AddQuest(first);
traceBoard.AddQuest(second);

Console.WriteLine(traceBoard.TryAssign(2, "аня"));
Console.WriteLine(traceBoard.TryAssign(1, "аня"));
Console.WriteLine(traceBoard.TryComplete(2));
Console.WriteLine(traceBoard.TryComplete(1));
Console.WriteLine(traceBoard.TryComplete(1));
Console.WriteLine(anya.Experience);
Console.WriteLine(second.AssignedHero == null);

Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());

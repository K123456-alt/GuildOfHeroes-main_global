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

// catalog.AddSession(new GameSession(1, "Вечерняя сессия", 25));
// catalog.AddSession(new GameSession(2, "Ночная сессия", 40));

// Console.WriteLine($"Старт №1 для Ведьмака: {catalog.TryStartSession(1, "Ведьмак 3")}");
// Console.WriteLine($"Старт №2 для Ведьмака: {catalog.TryStartSession(2, "ведьмак 3")}");
// Console.WriteLine($"Ведьмак 3 часов: {game1.HoursPlayed}");

// GameSession? s1 = catalog.FindSession(1);
// if (s1 != null) {
//     Console.WriteLine($"Отмена №1: {s1.TryCancel()}");
// }

// Console.WriteLine($"Старт №2 для Ведьмака: {catalog.TryStartSession(2, "Ведьмак 3")}");
// Console.WriteLine($"Завершение №2: {catalog.TryFinishSession(2)}");
// Console.WriteLine($"Ведьмак 3 часов: {game1.HoursPlayed}");

// Game? found = catalog.FindByTitle("Ведьмак 3");
// if (found != null) {
//     Console.WriteLine($"Через каталог: {found.HoursPlayed} часов");
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

// Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
// Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
// Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

// Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
// Hero? assigned = floatQuest.AssignedHero;
// if (assigned != null) {
//     Console.WriteLine($"Исполнитель: {assigned.Name}");
// }
// Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

// Console.WriteLine($"Завершение: {board.TryComplete(101)}");
// Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
// Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
// Console.WriteLine($"Опыт после повтора: {sergey.Experience}");



// Guild traceGuild = new Guild("Трассировка");
// Hero anya = new Hero("Аня", 120);
// traceGuild.AddHero(anya);

// QuestBoard traceBoard = new QuestBoard(traceGuild);
// Quest first = new Quest(1, "Первое", 100, 10);
// Quest second = new Quest(2, "Второе", 130, 20);
// traceBoard.AddQuest(first);
// traceBoard.AddQuest(second);

// Console.WriteLine(traceBoard.TryAssign(2, "аня"));
// Console.WriteLine(traceBoard.TryAssign(1, "аня"));
// Console.WriteLine(traceBoard.TryComplete(2));
// Console.WriteLine(traceBoard.TryComplete(1));
// Console.WriteLine(traceBoard.TryComplete(1));
// Console.WriteLine(anya.Experience);
// Console.WriteLine(second.AssignedHero == null);

// Console.WriteLine();
// Console.WriteLine(floatQuest.GetInfo());
// Console.WriteLine(sergey.GetInfo());

board.AddQuest(new Quest(101, "Вернуть поплавок", 100, 30));
board.TryAssign(101, "Сергей");
board.TryComplete(101);

board.AddQuest(new Quest(102, "Проверить нижнюю площадку", 100, 10));
board.AddQuest(new Quest(103, "Снять мерки для насоса больницы", 100, 20));
board.AddQuest(new Quest(104, "Обследовать ответвление", 100, 15));

Console.WriteLine($"Сергей на №102: {board.TryAssign(102, "Сергей")}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Отмена №102: {board.TryCancel(102)}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Завершение №103: {board.TryComplete(103)}");
Console.WriteLine($"Ярослав на №104: {board.TryAssign(104, "Ярослав")}");
Console.WriteLine($"Удалить Сергея: {board.TryRemoveMember("Сергей")}");

Console.WriteLine();
List<Quest> quests = board.GetQuests();
foreach (Quest quest in quests)
{
    Console.WriteLine(quest.GetInfo());
}

Console.WriteLine();
Console.WriteLine(sergey.GetInfo());
Quest? yaroslavQuest = board.FindActiveQuest("Ярослав");
if (yaroslavQuest != null)
{
    Console.WriteLine($"Ярослав сейчас: №{yaroslavQuest.Id} «{yaroslavQuest.Title}»");
}
else
{
    Console.WriteLine("Ярослав сейчас: свободен");
}

Quest? sergeyQuest = board.FindActiveQuest("Сергей");
if (sergeyQuest != null)
{
    Console.WriteLine($"Сергей сейчас: №{sergeyQuest.Id} «{sergeyQuest.Title}»");
}
else
{
    Console.WriteLine("Сергей сейчас: свободен");
}
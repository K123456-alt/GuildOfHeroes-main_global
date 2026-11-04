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

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

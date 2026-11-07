public static class Probe {
   public static void Run() {
    Console.WriteLine(">>> Проба <<<");
Guild traceGuild = new Guild("Трассировка");
Hero first = new Hero("Первый", 100);
Hero second = new Hero("Второй", 80);

traceGuild.Heroes.Add(first);
traceGuild.Heroes.Add(second);
traceGuild.Heroes.Add(first);

first.TakeDamage(30);

Console.WriteLine(traceGuild.Heroes.Count);
Console.WriteLine(traceGuild.Heroes[2].Health);
foreach (Hero hero in traceGuild.Heroes) {
    Console.WriteLine($"{hero.Name}: {hero.Health}");
}
Console.WriteLine(traceGuild.Heroes[traceGuild.Heroes.Count - 2].Name);

}

}

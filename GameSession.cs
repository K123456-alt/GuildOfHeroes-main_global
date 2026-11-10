// public class GameSession {
//     public int Id { get; private set; }
//     public string Title { get; private set; }
//     public int Hours { get; private set; }
//     public Game? AssignedGame { get; private set; }
//     public bool IsCompleted { get; private set; }

//     public GameSession(int id, string title, int hours) {
//         Id = id;

//         if (string.IsNullOrWhiteSpace(title)) {
//             Title = "Безымянная сессия";
//         } else {
//             Title = title.Trim();
//         }

//         Hours = hours;
//         if (Hours < 1) {
//             Hours = 1;
//         }

//         AssignedGame = null;
//         IsCompleted = false;
//     }

//     public bool TryStart(Game game) {
//         if (IsCompleted) {
//             return false;
//         }
//         if (AssignedGame != null) {
//             return false;
//         }
//         if (game.HoursPlayed + Hours > 10000) {
//             return false;
//         }

//         AssignedGame = game;
//         return true;
//     }

//     public bool TryFinish() {
//         if (IsCompleted) {
//             return false;
//         }

//         Game? game = AssignedGame;
//         if (game == null) {
//             return false;
//         }
//         if (game.HoursPlayed + Hours > 10000) {
//             return false;
//         }

//         game.AddHours(Hours);
//         IsCompleted = true;
//         return true;
//     }

//     public string GetInfo() {
//         string gameText = "не назначена";
//         if (AssignedGame != null) {
//             gameText = AssignedGame.Title;
//         }

//         string doneText = "нет";
//         if (IsCompleted) {
//             doneText = "да";
//         }

//         return $"№{Id} «{Title}»: игра {gameText}, выполнено: {doneText}";
//     }
// }
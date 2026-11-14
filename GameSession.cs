// public class GameSession {
//     public int Id { get; private set; }
//     public string Title { get; private set; }
//     public int Hours { get; private set; }
//     public Game? AssignedGame { get; private set; }
//     public GameSessionStatus Status { get; private set; }

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
//         Status = GameSessionStatus.Open;
//     }

//     public bool TryStart(Game game) {
//         if (Status != GameSessionStatus.Open) {
//             return false;
//         }
//         if (game.HoursPlayed + Hours > 10000) {
//             return false;
//         }

//         AssignedGame = game;
//         Status = GameSessionStatus.Active;
//         return true;
//     }

//     public bool TryFinish() {
//         if (Status != GameSessionStatus.Active) {
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
//         Status = GameSessionStatus.Completed;
//         return true;
//     }

//     public bool TryCancel() {
//         if (Status != GameSessionStatus.Open && Status != GameSessionStatus.Active) {
//             return false;
//         }

//         Status = GameSessionStatus.Cancelled;
//         return true;
//     }

//     public string GetStatusText() {
//         switch (Status) {
//             case GameSessionStatus.Open:
//                 return "открыта";
//             case GameSessionStatus.Active:
//                 return "активна";
//             case GameSessionStatus.Completed:
//                 return "выполнена";
//             case GameSessionStatus.Cancelled:
//                 return "отменена";
//             default:
//                 return "неизвестно";
//         }
//     }

//     public string GetInfo() {
//         string gameText = "не назначена";
//         if (AssignedGame != null) {
//             gameText = AssignedGame.Title;
//         }

//         return $"№{Id} «{Title}»: {GetStatusText()}, игра {gameText}";
//     }
// }
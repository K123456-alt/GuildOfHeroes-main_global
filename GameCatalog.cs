// public class GameCatalog
// {
//     private List<Game> _games = new List<Game>();
//     private List<GameSession> _sessions = new List<GameSession>();
//     public string Name { get; private set; }

//     public int GameCount
//     {
//         get { return _games.Count; }
//     }

//     public GameCatalog(string name)
//     {
//         Name = name;
//     }

//     public bool AddGame(Game game)
//     {
//         if (FindByTitle(game.Title) != null)
//         {
//             return false;
//         }

//         _games.Add(game);
//         return true;
//     }

//     public Game? FindByTitle(string title)
//     {
//         if (string.IsNullOrWhiteSpace(title))
//         {
//             return null;
//         }

//         string searchTitle = title.Trim();

//         foreach (Game game in _games)
//         {
//             if (string.Equals(game.Title, searchTitle, StringComparison.OrdinalIgnoreCase))
//             {
//                 return game;
//             }
//         }

//         return null;
//     }

//     public bool RemoveGame(string title)
//     {
//         Game? game = FindByTitle(title);
//         if (game == null)
//         {
//             return false;
//         }
//         return _games.Remove(game);
//     }

//     public List<Game> GetGames()
//     {
//         List<Game> result = new List<Game>();
//         foreach (Game game in _games)
//         {
//             result.Add(game);
//         }
//         return result;
//     }

//     public int CountHighlyRated(double minimum)
//     {
//         int count = 0;
//         foreach (Game game in _games)
//         {
//             if (game.Rating >= minimum)
//             {
//                 count += 1;
//             }
//         }
//         return count;
//     }
//     public bool IsBusy(Game game)
//     {
//         foreach (GameSession session in _sessions)
//         {
//             if (session.Status == GameSessionStatus.Active && session.AssignedGame == game)
//             {
//                 return true;
//             }
//         }
//         return false;
//     }

//     public bool TryStartSession(int sessionId, string gameTitle)
//     {
//         GameSession? session = FindSession(sessionId);
//         if (session == null)
//         {
//             return false;
//         }

//         Game? game = FindByTitle(gameTitle);
//         if (game == null)
//         {
//             return false;
//         }

//         if (IsBusy(game))
//         {
//             return false;
//         }

//         return session.TryStart(game);
//     }

//     public bool AddSession(GameSession session)
//     {
//         if (session.Status != GameSessionStatus.Open)
//         {
//             return false;
//         }
//         if (FindSession(session.Id) != null)
//         {
//             return false;
//         }
//         _sessions.Add(session);
//         return true;
//     }

//     public GameSession? FindSession(int sessionId)
//     {
//         foreach (GameSession session in _sessions)
//         {
//             if (session.Id == sessionId)
//             {
//                 return session;
//             }
//         }
//         return null;
//     }
//     public bool TryFinishSession(int sessionId)
//     {
//         GameSession? session = FindSession(sessionId);
//         if (session == null)
//         {
//             return false;
//         }
//         return session.TryFinish();
//     }
// }
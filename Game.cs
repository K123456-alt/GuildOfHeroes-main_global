// public class Game {
//     public string Title;
//     public string Genre;
//     public int ReleaseYear;
//     public double Rating;

//     public int HoursPlayed { get; private set; }

//     public Game(string title, string genre, int releaseYear, double rating) {
//         Title = title;
//         Genre = genre;
//         ReleaseYear = releaseYear;
//         Rating = rating;

//         HoursPlayed = 0;
//         if (HoursPlayed < 0) {
//             HoursPlayed = 0;
//         }
//         if (HoursPlayed > 10000) {
//             HoursPlayed = 10000;
//         }
//     }

//     public void AddHours(int hours) {
//         if (hours <= 0) {
//             return;
//         }

//         if (hours > 10000 - HoursPlayed) {
//             HoursPlayed = 10000;
//             return;
//         }

//         HoursPlayed += hours;
//     }
// }

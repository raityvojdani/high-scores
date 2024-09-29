namespace high_scores;

public class Program
{
    static void Main(string[] args)
    {
        // Create a list of sample scores
        List<int> scores = new List<int> { 10, 30, 90, 30, 100, 20, 10, 0, 30, 40, 40, 70, 70 };

        // Initialize the HighScores object with the list of scores
        HighScores highScores = new HighScores(scores);

        // Accessing the methods of HighScores class
        Console.WriteLine("All Scores: " + string.Join(", ", highScores.Scores()));
        Console.WriteLine("Latest Score: " + highScores.Latest());
        Console.WriteLine("Personal Best: " + highScores.PersonalBest());
        Console.WriteLine("Top Three Scores: " + string.Join(", ", highScores.PersonalTopThree()));

    }
}

using System;

namespace Structs
{
    struct HighScoreEntry
    {
        public float score;
        public string playerName;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            HighScoreEntry topScore;
            topScore.score = 0;
            topScore.playerName = "";

            Console.WriteLine(topScore.playerName + " " + topScore.score);
            Console.ReadLine();
        }
    }
}

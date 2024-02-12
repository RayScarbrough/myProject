using System;

namespace myProject
{
    class Game
    {
        
        private string _title;
        private string _genre;
        private int _rating; 

        // Default constructor
        public Game()
        {
        }

        // Parameterized constructor
        public Game(string title, string genre, int rating)
        {
            _title = title;
            _genre = genre;
            _rating = rating;
        }

      
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

      
        public string GetGenre()
        {
            return _genre;
        }

        public void SetGenre(string genre)
        {
            _genre = genre;
        }

        public int GetRating()
        {
            return _rating;
        }

        public void SetRating(int rating)
        {
            _rating = rating;
        }

        //  print game information
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {_title}, Genre: {_genre}, Rating: {_rating}/10");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // using the default constructor
            Game game1 = new Game();
            Game game2 = new Game();

            // created with the default constructor
            game1.SetTitle("The Witcher 3");
            game1.SetGenre("Action RPG");
            game1.SetRating(9);

            game2.SetTitle("Stardew Valley");
            game2.SetGenre("Farming Simulator");
            game2.SetRating(8);

            // using the parameterized constructor
            Game game3 = new Game("Halo", "FPS", 9);
            Game game4 = new Game("Among Us", "Party", 7);

          n
            game1.PrintInfo();
            game2.PrintInfo();
            game3.PrintInfo();
            game4.PrintInfo();
        }
    }
}
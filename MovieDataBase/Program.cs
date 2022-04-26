namespace MovieDataBase
{

    public class Program
    {
        public static void Main()
        {
            List<Movie> movieList = new List<Movie>();
            {
                movieList.Add(new Movie("Zoolander", "comedy"));
                movieList.Add(new Movie("Dumb and Dumber", "comedy"));
                movieList.Add(new Movie("Step Brothers", "comedy"));
                movieList.Add(new Movie("Scream", "horror"));
                movieList.Add(new Movie("The Babadook", "horror"));
                movieList.Add(new Movie("Nightmare on Elm Street", "horror"));
                movieList.Add(new Movie("Taken", "action"));
                movieList.Add(new Movie("John Wick", "action"));
                movieList.Add(new Movie("Captain America: Civil War", "action"));
                movieList.Add(new Movie("Princess Mononoke", "animated"));
                movieList.Add(new Movie("Ratatouille", "animated"));
                movieList.Add(new Movie("Spider-Man: Into the Spider-Verse", "animated"));
            };

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 12 movies in this list.");
            Console.WriteLine();

            bool goAgain = true;
            while (goAgain == true)
            {


                Console.WriteLine("What category are you interested in? We have comedy, horror, action, and animated movies");
                string category = Console.ReadLine().ToLower().Trim();
                foreach(Movie title in movieList)
                {
                    if (category == "comedy")
                    {
                        List<string>titles = new List<string>()
                        {
                            "Zoolander",
                            "Dumb and Dumber",
                            "Step Brothers"
                        };
                        Console.WriteLine(titles);
                    }
                    else if(category == "horror")
                    {
                        List<string> titles = new List<string>()
                        {
                            "Scream",
                            "The Babadook",
                            "Nightmare on Elm Street"
                        };
                        Console.WriteLine(titles);
                    }
                    else if(category == "action")
                    {
                        List<string> titles = new List<string>()
                        {
                            "Taken",
                            "John Wick",
                            "Captain America: Civil War"
                        };
                        Console.WriteLine(titles);
                    }
                    else if(category == "animated")
                    {
                        List<string> titles = new List<string>()
                        {
                            "Princess Mononoke",
                            "Ratatouille",
                            "Spider-Man:Into the Spider-Verse"
                        };
                        Console.WriteLine(titles);
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry that is not a category we currently have.");
                    }

                }

            }
            while (goAgain == true)
            {


                Console.WriteLine("Would you like to enter another category? Please enter y or n:");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "y" || input == "yes")
                {
                    goAgain = true;
                }
                else if (input == "n" || input == "no")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that response, please enter y or n:");
                    continue;
                }
            }
            
        }
    }
}


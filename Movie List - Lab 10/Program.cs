using System;
using System.Collections.Generic;

namespace Movie_List___Lab_10
{
	class Program
	{
		static void Main(string[] args)
		{
			//Creating a new List called movieList
			List<Movie> movieList = new List<Movie>
			{
				//Adding Titles and Genres to the  Class Movie, notice syntax
				new Movie("The Thin Red Line", "Drama"),
				new Movie("Charlie and the Chocolate Factory", "Comedy"),
				new Movie("SemiPro", "Comedy"),
				new Movie("DieHard With a Vengeance", "Action"),
				new Movie("John Wick 2", "Action"),
				new Movie("Good Will Hunting", "Drama"),
				new Movie("The Empire Strikes Back", "Sci-Fi"),
				new Movie("Blade Runner", "Sci-Fi"),
				new Movie("Between Two Ferns", "Comedy"),
				new Movie("Clear and Present Danger", "Action"),
				new Movie("It's A Wonderful Life", "Drama"),
				new Movie("Westworld", "Sci-Fi")
			};
			bool goAgain = true;
			do
			{
				Console.WriteLine("What kind of movie would you like to see?");

				Movie.PrintMovieGenres(movieList);

				string selection = Console.ReadLine();

				Movie.PrintMovieByType(movieList, selection);
				//Ask the User if they want to go again.
				string repeat = GetUserInput($"Would you like to select another genre? (y/n)");
				if (repeat == "y")
				{
					goAgain = true;
				}
				else
				{
					goAgain = false;
				}
			}
			while (goAgain);
			Console.WriteLine("Hope you enjoy your movie!");
		}
		public static string GetUserInput(string message)
		{
			Console.WriteLine(message);
			string input = Console.ReadLine();
			return input;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List___Lab_10
{	
	//Movie - Title(string), Genre(string)
	class Movie
	{
		//fields
		private string title;
		private string genre;

		//properties
		#region properties
		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		public string Genre
		{
			get { return genre; }
			set { genre = value; }
		}
		#endregion
		public Movie()
		{

		}
		public Movie(string _title, string _genre)
		{
			title = _title;
			genre = _genre;
		}
		public static List<string> GetMovieGenres(List<Movie> movies)
		{
			List<string> movieGenres = new List<string>();
				
				foreach(Movie movie in movies)
				{
					if (!movieGenres.Contains(movie.Genre))
				{
					movieGenres.Add(movie.Genre);
				}
			}
			return movieGenres;
		}
		public static void PrintMovieGenres(List<Movie> movieList)
		{
			List<string> movieGenres = Movie.GetMovieGenres(movieList);
			for (int i = 0; i < movieGenres.Count; i++)
			{
				Console.WriteLine($"{movieGenres[i]}");
			}
		}
		public static void PrintMovieByType(List<Movie> movieList, string selection)
		{
			for (int i = 0; i < movieList.Count; i++)
			{
				if (selection == movieList[i].Genre)
				{
					Console.WriteLine($"{movieList[i].Title} is a {movieList[i].Genre}");
				}
			}

		}
	}
}

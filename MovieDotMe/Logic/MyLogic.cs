using MovieDotMe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDotMe.Logic;

public class MyLogic   
{
    private static readonly string myDbPath = "C:\\Users\\Mehrshad\\source\\repos\\MovieDotMe\\MovieDotMe\\MyDb\\Db.json";
    private static readonly string MyMovieDbPath = "C:\\Users\\Mehrshad\\source\\repos\\MovieDotMe\\MovieDotMe\\MyDb\\DbMovie.json";
    private static readonly string myFaveDbPath = "C:\\Users\\Mehrshad\\source\\repos\\MovieDotMe\\MovieDotMe\\MyDb\\FaveMovieDb.json";

    // data part
    public static void CreateData()
    {
        var isUserExist = GetAllUser();
        if(isUserExist.Count == 0)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    UserID = 1,
                    Username = "mehrshad",
                    Password = "mehr1234"
                },
                new User()
                {
                    UserID = 2 ,
                    Username = "aria",
                    Password = "aria1234"
                }
            };

            string json = JsonConvert.SerializeObject(users);
            using (StreamWriter sw = new StreamWriter(myDbPath))
            {
                sw.WriteLine(json);
                sw.Close();
            }
        }
    }
    public static void CreateMovies()
    {
        List<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                MovieID = 1,
                Title = "tenet",
                Director = "nolan",
            },
            new Movie()
            {
                MovieID = 2 ,
                Title = "fight club",
                Director = "david fincher"
            },
            new Movie()
            {
                MovieID = 3 ,
                Title = "killer",
                Director = "fincher"
            },
            new Movie()
            {
                MovieID = 4 ,
                Title = "batman",
                Director = "nolan"
            }
        };

        var myMovies = JsonConvert.SerializeObject(movies);
        using( var rd = new StreamWriter(MyMovieDbPath))
        {
            rd.WriteLine(myMovies);
            rd.Close();
        }
    }
    public static List<User> GetAllUser() 
    {
        using (StreamReader sr = new StreamReader(myDbPath))
        {
            var json = sr.ReadToEnd();
            var users = JsonConvert.DeserializeObject<List<User>>(json);
            sr.Close();

            if (users != null)
                return users;
        }

        return null;
    }
    public static List<Movie> GetAllMovies()
    {
        using(StreamReader sr = new StreamReader(MyMovieDbPath))
        {
            var json = sr.ReadToEnd();
            var movies = JsonConvert.DeserializeObject<List<Movie>>(json);

            return movies;
        }

        return null;
    }
    public static User GetUser(string username)
    {
        var user = GetAllUser();

        return user.FirstOrDefault(x => x.Username == username);
    }

    // signin and sign up 
    public static bool Login(string username , string password)
    {

        using( StreamReader rd = new StreamReader( myDbPath ))
        {
            var json = rd.ReadToEnd();
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            rd.Close();

            if(users != null)
            {
                var user = users.FirstOrDefault( x => x.Username == username && x.Password == password );
                if(user != null)
                    return true;
            }
        }

        return false; 
    }
    public static FaveMovies GetFaveMovie(string username)
    {
        using ( var rd = new StreamReader(myFaveDbPath))
        {
            var json = rd.ReadToEnd();
            var FaveMovies = JsonConvert.DeserializeObject<List<FaveMovies>>(json);
            rd.Close();

            return FaveMovies.FirstOrDefault(x => x.Username == username);
        }

    }
    public static void SaveFavoritMovies(List<string> movieTitle , User user)
    {
        
        var faveMovie = new FaveMovies()
        {
            Username = user.Username,
            Titles = movieTitle
        };

        var favesSer = JsonConvert.SerializeObject(faveMovie);
        using( var wr = new StreamWriter(myFaveDbPath))
        {
            wr.WriteLine(favesSer);
            wr.Close();
        }
    }
}


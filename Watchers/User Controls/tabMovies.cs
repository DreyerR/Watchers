using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Models;
using Watchers.Properties;

namespace Watchers
{
    public partial class tabMovies : UserControl
    {
        private static tabMovies _instance;
        private static List<Movie> movies = new List<Movie>();

        public static tabMovies Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabMovies();
                    ConstructMovies();
                }
                return _instance;
            }
        }

        public tabMovies()
        {
            InitializeComponent();
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string movieID = btn.Tag.ToString();

            foreach (Movie movie in movies)
            {
                if (movie.MovieID == movieID)
                {
                    movie.MovieID = movieID;
                    MainMenu main = (MainMenu)this.FindForm();
                    main.BtnBooking_Click(sender, e, movie);
                    break;
                }
            }
        }

        private static void ConstructMovies()
        {
            Movie movie1 = new Movie
            {
                Name = "Bad Boys For Life",
                MovieID = "m001",
                MovieImage = Resources.m001,
                CinemaNumber = 2,
                Description = "Bad Boys for Life is a 2020 American action comedy film that is the sequel to Bad Boys II (2003) and the third installment in the Bad Boys trilogy. The film is directed by Adil & Bilall and written by Chris Bremner, Peter Craig and Joe Carnahan. It stars returning actors Will Smith and Martin Lawrence. The film's cast also includes Paola Núñez, Vanessa Hudgens, Alexander Ludwig, Charles Melton, Kate del Castillo, Nicky Jam, and Joe Pantoliano, who appear in supporting roles. It was produced by Smith, Jerry Bruckheimer, and Doug Belgrad. In Bad Boys for Life, Miami detectives Mike Lowrey (Smith) and Marcus Burnett (Lawrence) investigate a string of murders tied to Lowrey's troubled past."
            };

            Movie movie2 = new Movie
            {
                Name = "Black Widow",
                MovieID = "m002",
                MovieImage = Resources.m002,
                CinemaNumber = 5,
                Description = "At birth the Black Widow (aka Natasha Romanova) is given to the KGB, which grooms her to become its ultimate operative. When the U.S.S.R. breaks up, the government tries to kill her as the action moves to present-day New York, where she is a freelance operative."
            };

            Movie movie3 = new Movie
            {
                Name = "Do Little",
                MovieID = "m003",
                MovieImage = Resources.m003,
                CinemaNumber = 4,
                Description = "Dr. John Dolittle lives in solitude behind the high walls of his lush manor in 19th-century England. His only companionship comes from an array of exotic animals that he speaks to on a daily basis. But when young Queen Victoria becomes gravely ill, the eccentric doctor and his furry friends embark on an epic adventure to a mythical island to find the cure."
            };

            Movie movie4 = new Movie
            {
                Name = "Fantasy Island",
                MovieID = "m004",
                MovieImage = Resources.m004,
                CinemaNumber = 1,
                Description = "A mysterious man invites a group of lucky guests to his secretive resort to fulfil their darkest fantasies. However, when people start arriving, things take an unexpected turn."
            };

            Movie movie5 = new Movie
            {
                Name = "Mulan",
                MovieID = "m005",
                MovieImage = Resources.m005,
                CinemaNumber = 2,
                Description = "To save her ailing father from serving in the Imperial Army, a fearless young woman disguises herself as a man to battle northern invaders in China."
            };

            Movie movie6 = new Movie
            {
                Name = "No Time To Die",
                MovieID = "m006",
                MovieImage = Resources.m006,
                CinemaNumber = 3,
                Description = "Recruited to rescue a kidnapped scientist, globe-trotting spy James Bond finds himself hot on the trail of a mysterious villain, who's armed with a dangerous new technology."
            };

            Movie movie7 = new Movie
            {
                Name = "Frozen 2",
                MovieID = "m007",
                MovieImage = Resources.m007,
                CinemaNumber = 4,
                Description = "Elsa the Snow Queen has an extraordinary gift -- the power to create ice and snow. But no matter how happy she is to be surrounded by the people of Arendelle, Elsa finds herself strangely unsettled. After hearing a mysterious voice call out to her, Elsa travels to the enchanted forests and dark seas beyond her kingdom -- an adventure that soon turns into a journey of self-discovery."
            };

            Movie movie8 = new Movie
            {
                Name = "Birds Of Prey",
                MovieID = "m008",
                MovieImage = Resources.m008,
                CinemaNumber = 5,
                Description = "It's open season on Harley Quinn when her explosive breakup with the Joker puts a big fat target on her back. Unprotected and on the run, Quinn faces the wrath of narcissistic crime boss Black Mask, his right-hand man, Victor Zsasz, and every other thug in the city. But things soon even out for Harley when she becomes unexpected allies with three deadly women."
            };

            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            movies.Add(movie8);
        }
    }
}

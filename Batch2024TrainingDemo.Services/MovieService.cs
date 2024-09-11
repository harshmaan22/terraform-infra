using Batch2024TrainingDemo.Contracts;

namespace Batch2024TrainingDemo.Services
{
    public class MovieService : IMovieService
    {
        private readonly ILocation _location;
        private readonly ISample _sample;

        public MovieService(ILocation location, ISample sample)
        {
            _location = location;
            _sample = sample;
        }
        public bool AddMovie(Movie reqquest)
        {
            //call database insert new movie into it
            return false;
        }

        public List<Movie> GetMovies()
        {
            string location = _location.GetLocation();
            string sample = _sample.GetSampleName();    
            return new List<Movie>() {
                new Movie() { DirectorName ="Rahul",MovieName="ABC",Seats=99,Summary="Thriller"},
                new Movie() { DirectorName ="Karan",MovieName="KGF",Seats=99,Summary="Thriller"},
                new Movie() { DirectorName ="Rohit",MovieName="Fighter",Seats=99,Summary="Thriller"}
            };
        }
    }

    public class Location : ILocation
    {
        public string GetLocation()
        {
            return "NOIDA";
        }
    }
    public class Sample : ISample
    {
        public string GetSampleName()
        {
            return "SAMPLE NAME";
        }
    }

    public interface ISample
    {
        string GetSampleName();
    }
}
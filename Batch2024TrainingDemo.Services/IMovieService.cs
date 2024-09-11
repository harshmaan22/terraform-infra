using Batch2024TrainingDemo.Contracts;

namespace Batch2024TrainingDemo.Services
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
        bool AddMovie(Movie reqquest);
    }

    public interface ILocation
    {
       string GetLocation();
    }
}
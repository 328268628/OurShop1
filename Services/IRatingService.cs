using Entitis;

namespace Services
{
    public interface IRatingService
    {
        Task<Rating> AddRating(Rating rating);
    }
}
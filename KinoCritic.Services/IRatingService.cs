using System.Collections.Generic;
using KinoCritic.Data.Entities;

namespace KinoCritic.Services
{
    public interface IRatingService
    {
        IEnumerable<Rating> GetAllRatings();
        Rating GetRatingById(int id);
        void CreateRating(Rating rating);
        void UpdateRating(Rating rating);
        void DeleteRating(int id);
    }
}

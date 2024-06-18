using System.Collections.Generic;
using System.Linq;
using KinoCritic.Data;
using KinoCritic.Data.Entities;

namespace KinoCritic.Services
{
    public class RatingService : IRatingService
    {
        private readonly KinoCriticContext _context;

        public RatingService(KinoCriticContext context)
        {
            _context = context;
        }

        public IEnumerable<Rating> GetAllRatings()
        {
            return _context.Ratings.ToList();
        }

        public Rating GetRatingById(int id)
        {
            return _context.Ratings.Find(id);
        }

        public void CreateRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }

        public void UpdateRating(Rating rating)
        {
            _context.Ratings.Update(rating);
            _context.SaveChanges();
        }

        public void DeleteRating(int id)
        {
            var rating = _context.Ratings.Find(id);
            if (rating != null)
            {
                _context.Ratings.Remove(rating);
                _context.SaveChanges();
            }
        }
    }
}

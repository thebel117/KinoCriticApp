using System.Collections.Generic;
using System.Linq;
using KinoCritic.Data;
using KinoCritic.Data.Entities;

namespace KinoCritic.Services
{
    public class ShowService : IShowService
    {
        private readonly KinoCriticContext _context;

        public ShowService(KinoCriticContext context)
        {
            _context = context;
        }

        public IEnumerable<Show> GetAllShows()
        {
            return _context.Shows.ToList();
        }

        public Show GetShowById(int id)
        {
            return _context.Shows.Find(id);
        }

        public void CreateShow(Show show)
        {
            _context.Shows.Add(show);
            _context.SaveChanges();
        }

        public void UpdateShow(Show show)
        {
            _context.Shows.Update(show);
            _context.SaveChanges();
        }

        public void DeleteShow(int id)
        {
            var show = _context.Shows.Find(id);
            if (show != null)
            {
                _context.Shows.Remove(show);
                _context.SaveChanges();
            }
        }
    }
}

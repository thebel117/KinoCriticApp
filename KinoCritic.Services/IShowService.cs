using System.Collections.Generic;
using KinoCritic.Data.Entities;

namespace KinoCritic.Services
{
    public interface IShowService
    {
        IEnumerable<Show> GetAllShows();
        Show GetShowById(int id);
        void CreateShow(Show show);
        void UpdateShow(Show show);
        void DeleteShow(int id);
    }
}

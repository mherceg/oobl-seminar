using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.DAL.Database;
using Tracktor.DAL.EFRepository;
using Tracktor.Domain;

namespace Tracktor.DAL.Repositories
{
    public class PlaceRepository : EFRepository<PlaceEntity, Place>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public PlaceRepository(TracktorDb context) : base (context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Insert method for the place entities
        /// </summary>
        /// <param name="placeDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(PlaceEntity placeDomain, Action saveChanges)
        {
            Place placeDAL = Mapper.ToDALModel(placeDomain);
            DbSet.Add(placeDAL);
            saveChanges();
            return placeDAL.Id;
        }

        /// <summary>
        /// Get All method for place entities
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PlaceEntity> GetAll()
        {
            IEnumerable<Place> placesDAL = DbSet;
            List<PlaceEntity> placesDomain = new List<PlaceEntity>();
            foreach (var place in placesDAL)
            {
                placesDomain.Add(Mapper.ToDomainModel(place));
            }
            return placesDomain;
        }

        /// <summary>
        /// Get filtered place entities
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="active"></param>
        /// <param name="future"></param>
        /// <returns></returns>
        public IEnumerable<PlaceEntity> GetMany(IDictionary<string, bool> filters, bool active, bool future)
        {
            //Dohvat svih aktivnih i buducih dogadjaja
            List<Info> activeInfos = this.Context.Set<Info>().Where(i => i.Time < DateTime.Now && i.EndTime > DateTime.Now).ToList();
            List<Info> futureInfos = this.Context.Set<Info>().Where(i => i.Time > DateTime.Now).ToList();

            //filter po active i future uvjetima
            List<Info> filterInfo = new List<Info>();
            if (active)
                filterInfo.AddRange(activeInfos);
            if (future)
                filterInfo.AddRange(futureInfos);

            //filter po kategorijama
            List<Info> filtered = new List<Info>();
            foreach(var category in filters)
            {
                if(category.Value)
                    filtered.AddRange(
                                (from info in filterInfo
                                where info.Category.Name.Equals(category.Key)
                                select info).ToList()
                                );
            }

            //dohvat svih mjesta iz filtriranih dogadjaja + distinct da ne bude dupliciranja mjesta
            List<Place> placesDAL = filtered.Select(i => i.Place).ToList();
            placesDAL = placesDAL.GroupBy(p => p.Id).Select(grp => grp.First()).ToList();

            List<PlaceEntity> placesDomain = new List<PlaceEntity>();
            foreach (var place in placesDAL)
            {
                placesDomain.Add(Mapper.ToDomainModel(place));
            }
            return placesDomain;
        }

        /// <summary>
        /// Get favorite places for certain user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<PlaceEntity> GetFavorite(int userId)
        {
            //IEnumerable<Place> places = DbSet;
            //List<FavoritePlace> favoritePlace = this.Context.Set<FavoritePlace>().Where(fp => fp.UserId == userId).ToList();

            //var favPlaces = (from Item1 in favoritePlace
            //                 join Item2 in places
            //                 on Item1.PlaceId equals Item2.Id
            //                 select Item2).ToList();

            //List<PlaceEntity> placesDomain = new List<PlaceEntity>();
            //foreach (var place in favPlaces)
            //{
            //    placesDomain.Add(Mapper.ToDomainModel(place));
            //}
            //return placesDomain;

            User userDAL = this.Context.User.Find(userId);
            List<PlaceEntity> placesDomain = new List<PlaceEntity>();
            foreach (var place in userDAL.Place)
            {
                placesDomain.Add(Mapper.ToDomainModel(place));
            }
            return placesDomain;


        }

        /// <summary>
        /// Get sponsored places for certain user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<PlaceEntity> GetSponsorship(int userId)
        {
            //IEnumerable<Place> places = DbSet;
            //List<Sponsorship> sponsorship = this.Context.Set<Sponsorship>().Where(fp => fp.UserId == userId).ToList();

            //var sponsorPlaces = (from Item1 in sponsorship
            //                 join Item2 in places
            //                 on Item1.PlaceId equals Item2.Id
            //                 select Item2).ToList();

            //List<PlaceEntity> placesDomain = new List<PlaceEntity>();
            //foreach (var place in sponsorPlaces)
            //{
            //    placesDomain.Add(Mapper.ToDomainModel(place));
            //}
            //return placesDomain;

            User userDAL = this.Context.User.Find(userId);
            List<PlaceEntity> placesDomain = new List<PlaceEntity>();
            foreach (var place in userDAL.Place1)
            {
                placesDomain.Add(Mapper.ToDomainModel(place));
            }
            return placesDomain;

        }
        #endregion
    }
}

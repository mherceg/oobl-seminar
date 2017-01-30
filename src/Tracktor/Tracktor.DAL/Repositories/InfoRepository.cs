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
    public class InfoRepository : EFRepository<InfoEntity, Info>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public InfoRepository(TracktorDb context) : base(context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Insert method for the place entities
        /// </summary>
        /// <param name="placeDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(InfoEntity infoDomain, Action saveChanges)
        {
            Info infoDAL = Mapper.ToDALModel(infoDomain);
            DbSet.Add(infoDAL);
            saveChanges();
            return infoDAL.Id;
        }

        /// <summary>
        /// Get filtered place entities
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="active"></param>
        /// <param name="future"></param>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public IEnumerable<InfoEntity> GetMany(IDictionary<string, bool> filters, bool active, bool future, int placeId)
        {
            //Dohvat svih aktivnih i buducih dogadjaja
            List<Info> activeInfos = this.Context.Set<Info>().Where(i => i.Time < DateTime.Now && i.EndTime > DateTime.Now && i.PlaceId == placeId).ToList();
            List<Info> futureInfos = this.Context.Set<Info>().Where(i => i.Time > DateTime.Now && i.PlaceId == placeId).ToList();

            //filter po active i future uvjetima
            List<Info> filterInfo = new List<Info>();
            if (active)
                filterInfo.AddRange(activeInfos);
            if (future)
                filterInfo.AddRange(futureInfos);

            //filter po kategorijama
            List<Info> filtered = new List<Info>();
            foreach (var category in filters)
            {
                if (category.Value)
                    filtered.AddRange(
                                (from info in filterInfo
                                 where info.Category.Name.Equals(category.Key)
                                 select info).ToList()
                                );
            }

            List<InfoEntity> infosDomain = new List<InfoEntity>();
            foreach (var info in filtered)
            {
                infosDomain.Add(Mapper.ToDomainModel(info));
            }
            return infosDomain.OrderBy(i => i.time);
        }

        /// <summary>
        /// Get filtered place entities
        /// </summary>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public IEnumerable<InfoEntity> GetByPlace(int placeId)
        {
            //Dohvat svih aktivnih i buducih dogadjaja na nekom mjestu
            List<Info> activeInfos = this.Context.Set<Info>().Where(i => i.Time < DateTime.Now && i.EndTime > DateTime.Now && i.PlaceId == placeId).ToList();
            List<Info> futureInfos = this.Context.Set<Info>().Where(i => i.Time > DateTime.Now && i.PlaceId == placeId).ToList();

            List<Info> infosByPlace = new List<Info>();
            infosByPlace.AddRange(activeInfos);
            infosByPlace.AddRange(futureInfos);

            List<InfoEntity> infosDomain = new List<InfoEntity>();
            foreach (var info in infosByPlace)
            {
                infosDomain.Add(Mapper.ToDomainModel(info));
            }
            return infosDomain.OrderBy(i => i.time);
        }

		public IEnumerable<InfoEntity> GetAll() {
			List<Info> allInfos = this.Context.Set<Info>().ToList();
			List<InfoEntity> infosDomain = new List<InfoEntity>();
			foreach (var info in allInfos)
			{
				infosDomain.Add(Mapper.ToDomainModel(info));
			}
			return infosDomain.OrderBy(i => i.time);

		}
		#endregion
	}
}

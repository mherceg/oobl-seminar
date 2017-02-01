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
    public class UserRepository : EFRepository<UserEntity, User>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(TracktorDb context) : base(context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// generic Insert method for the entities
        /// </summary>
        /// <param name="userDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(UserEntity userDomain, Action saveChanges)
        {
            User userDAL = Mapper.ToDALModel(userDomain);
            DbSet.Add(userDAL);
            saveChanges();
            return userDAL.Id;
        }

		public int Update(UserEntity userDomain, Action saveChanges)
		{
			User userDAL = Mapper.ToDALModel(userDomain);
			userDAL.Id = userDomain.Id;
			this.Context.Entry(userDAL).State = System.Data.Entity.EntityState.Modified;
			saveChanges();
			return userDAL.Id;
		}

		public void Remove(int userId, Action saveChanges)
		{
			User userDAL = DbSet.FirstOrDefault(c => c.Id == userId);
			DbSet.Remove(userDAL);
			saveChanges();
			/*return true;

			User userDAL = Mapper.ToDALModel(userDomain);
			userDAL.Id = userDomain.Id;
			this.Context.Entry(userDAL).State = System.Data.Entity.EntityState.Deleted;
			saveChanges();
			//return userDAL.Id;*/
		}


		/// <summary>
		/// specific method to check if entity exists
		/// </summary>
		/// <param name="predicate">Criteria to match on</param>
		/// <returns></returns>
		public bool Exists(Func<User, bool> predicate)
        {
            return this.Context.User.Any(predicate);
        }

        /// <summary>
        /// generic Get method for Entities
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity GetByID(object id)
        {
            User userDAL = DbSet.Find(id);
            //List<FavoritePlace> favoritePlace = this.Context.Set<FavoritePlace>().Where(fp => fp.UserId == userDAL.Id).ToList();
            //List<Sponsorship> sponsorship = this.Context.Set<Sponsorship>().Where(s => s.UserId == userDAL.Id).ToList();
            //List<Place> places = this.Context.Set<Place>().ToList();

            //var favPlaces = (from Item1 in favoritePlace
            //                    join Item2 in places
            //                    on Item1.PlaceId equals Item2.Id
            //                select Item2).ToList();

            //var spoPlaces = (from Item1 in sponsorship
            //                 join Item2 in places
            //                 on Item1.PlaceId equals Item2.Id
            //                 select Item2).ToList();


            UserEntity userDomain = Mapper.ToDomainModel(userDAL);

            return userDomain;
        }

        /// <summary>
        /// Gets a single record by the specified criteria (usually the unique identifier)
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A single record that matches the specified criteria</returns>
        public UserEntity GetSingle(Func<User, bool> predicate)
        {
            User userDAL = DbSet.Single<User>(predicate);
            //List<FavoritePlace> favoritePlace = this.Context.Set<FavoritePlace>().Where(fp => fp.UserId == userDAL.Id).ToList();
            //List<Sponsorship> sponsorship = this.Context.Set<Sponsorship>().Where(s => s.UserId == userDAL.Id).ToList();
            //List<Place> places = this.Context.Set<Place>().ToList();

            //var favPlaces = (from Item1 in favoritePlace
            //                 join Item2 in places
            //                 on Item1.PlaceId equals Item2.Id
            //                 select Item2).ToList();

            //var spoPlaces = (from Item1 in sponsorship
            //                 join Item2 in places
            //                 on Item1.PlaceId equals Item2.Id
            //                 select Item2).ToList();


            UserEntity userDomain = Mapper.ToDomainModel(userDAL);

            return userDomain;
        }



        //Je li ovome mjesto ovdje???

        /// <summary>
        /// Insert relationship about user and favourite place
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public void AddFavoritePlace(int userId, int placeId)
        {
            User userDAL = DbSet.Find(userId);
            Place placeDAL = this.Context.Place.Find(placeId);
            userDAL.Place.Add(placeDAL);

            //if(this.Context.FavoritePlace.Any(fp => fp.UserId == userId && fp.PlaceId == placeId))
            //{
            //    throw new Exception("Mjesto je već dodano u listu favorita!");
            //}
            //var new_favoritePlace = new FavoritePlace()
            //{
            //    UserId = userId,
            //    PlaceId = placeId
            //};

            //this.Context.FavoritePlace.Add(new_favoritePlace);
        }

        /// <summary>
        /// Insert relationship about user and sponsored place
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public void AddSponsorPlace(int userId, int placeId)
        {
            User userDAL = DbSet.Find(userId);
            Place placeDAL = this.Context.Place.Find(placeId);
            userDAL.Place1.Add(placeDAL);

            //if (this.Context.Sponsorship.Any(sp => sp.UserId == userId && sp.PlaceId == placeId))
            //{
            //    throw new Exception("Mjesto je već dodano u listu sponzoriranih!");
            //}
            //var new_sponsorPlace = new Sponsorship()
            //{
            //    UserId = userId,
            //    PlaceId = placeId
            //};

            //this.Context.Sponsorship.Add(new_sponsorPlace);

        }

        /// <summary>
        /// Delete relationship about user and favourite place
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public void RemoveFavoritePlace(int userId, int placeId)
        {
            User userDAL = DbSet.Find(userId);
            Place placeDAL = this.Context.Place.Find(placeId);
            if (placeDAL != null)
                userDAL.Place.Remove(placeDAL);

            //if (!this.Context.FavoritePlace.Any(fp => fp.UserId == userId && fp.PlaceId == placeId))
            //{
            //    throw new Exception("Mjesto nije u listi favorita!");
            //}
            //var favoritePlace = this.Context.FavoritePlace.Single(fp => fp.UserId == userId && fp.PlaceId == placeId);
            //this.Context.FavoritePlace.Remove(favoritePlace);

        }

        /// <summary>
        /// Delete relationship about user and sponsored place
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public void RemoveSponsorPlace(int userId, int placeId)
        {
            User userDAL = DbSet.Find(userId);
            Place placeDAL = this.Context.Place.Find(placeId);
            if (placeDAL != null)
                userDAL.Place1.Remove(placeDAL);

            //if (!this.Context.Sponsorship.Any(fp => fp.UserId == userId && fp.PlaceId == placeId))
            //{
            //    throw new Exception("Mjesto nije u sponzor listi!");
            //}
            //var sponsorPlace = this.Context.Sponsorship.Single(sp => sp.UserId == userId && sp.PlaceId == placeId);
            //this.Context.Sponsorship.Remove(sponsorPlace);

        }

		public IEnumerable<UserEntity> GetAll()
		{
			List<User> allUsers = this.Context.Set<User>().ToList();
			List<UserEntity> usersDomain = new List<UserEntity>();
			foreach (var user in allUsers)
			{
				usersDomain.Add(Mapper.ToDomainModel(user));
			}
			return usersDomain.OrderBy(i => i.Id);
		}

		
		#endregion
	}
}
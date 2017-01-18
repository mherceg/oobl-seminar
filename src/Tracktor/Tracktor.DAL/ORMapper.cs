using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.DAL.Database;
using Tracktor.Domain;

namespace Tracktor.DAL
{
    public class ORMapper
    {
        //To Domain
        public CategoryEntity ToDomainModel(Category category)
        {
            CategoryEntity categoryDomain = new CategoryEntity()
            {
                Id = category.Id,
                Name = category.Name
            };

            return categoryDomain;
        }

        public CommentEntity ToDomainModel(Comment comment)
        {
            List<ReputationCommentEntity> reputations = new List<ReputationCommentEntity>();
            foreach (var rep in comment.ReputationComment)
            {
                reputations.Add(this.ToDomainModel(rep));
            }

            CommentEntity commentDomain = new CommentEntity()
            {
                Id = comment.Id,
                EndTime = comment.Time,
                UserId = comment.UserId,
                ContentInfoId = comment.InfoId,
                Content = comment.Content,
                user = this.ToDomainModel(comment.User),
                reputation = reputations
            };

            return commentDomain;
        }

        public InfoEntity ToDomainModel(Info info)
        {
            List<CommentEntity> comments = new List<CommentEntity>();
            foreach (var comment in info.Comment)
            {
                comments.Add(this.ToDomainModel(comment));
            }

            List<ReputationInfoEntity> reputations = new List<ReputationInfoEntity>();
            foreach (var rep in info.ReputationInfo)
            {
                reputations.Add(this.ToDomainModel(rep));
            }

            InfoEntity infoDomain = new InfoEntity()
            {
                Id = info.Id,
                time = info.Time,
                endTime = (DateTime)info.EndTime,
                content = info.Content,
                categoryId = info.CategoryId,
                userId = info.UserId,
                placeId = info.PlaceId,
                category = this.ToDomainModel(info.Category),
                user = this.ToDomainModel(info.User),
                place = this.ToDomainModel(info.Place),
                comments = comments,
                reputation = reputations
            };

            return infoDomain;
        }

        public PlaceEntity ToDomainModel (Place place)
        {
            PlaceEntity placeDomain = new PlaceEntity()
            {
                Id = place.Id,
                Name = place.Name,
                Location = new GeoCoordinate(place.Location.Latitude, place.Location.Longitude)
            };

            return placeDomain;
        }

        public ReputationCommentEntity ToDomainModel(ReputationComment reputation)
        {
            ReputationCommentEntity repCommDomain = new ReputationCommentEntity()
            {
                Id = reputation.Id,
                UserId = reputation.UserId,
                ContentCommentId = reputation.CommentId,
                Score = reputation.Score,
                user = this.ToDomainModel(reputation.User)
            };

            return repCommDomain;
        }

        public ReputationInfoEntity ToDomainModel(ReputationInfo reputation)
        {
            ReputationInfoEntity repInfoDomain = new ReputationInfoEntity()
            {
                Id = reputation.Id,
                UserId = reputation.UserId,
                ContentCommentId = reputation.InfoId,
                Score = reputation.Score,
                user = this.ToDomainModel(reputation.User)
            };

            return repInfoDomain;
        }

        public UserTypeEntity ToDomainModel (UserType userType)
        {
            UserTypeEntity userTypeDomain = new UserTypeEntity()
            {
                Id = userType.Id,
                Type = userType.Type
            };

            return userTypeDomain;
        }

        public UserEntity ToDomainModel(User user, List<Place> favPlaces, List<Place> spoPlaces)
        {
            List<PlaceEntity> favoritePlaces = new List<PlaceEntity>();
            foreach(var place in favPlaces)
            {
                favoritePlaces.Add(this.ToDomainModel(place));
            }

            List<PlaceEntity> sponsorPlaces = new List<PlaceEntity>();
            foreach (var place in spoPlaces)
            {
                sponsorPlaces.Add(this.ToDomainModel(place));
            }

            UserEntity userDomain = new UserEntity()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                FullName = user.FullName,
                IsActive = user.IsActive,
                UserTypeId = user.UserTypeId,
                FavoritePlaces = favoritePlaces,
                SponsorshipPlaces = sponsorPlaces,
                Type = this.ToDomainModel(user.UserType)
            };

            return userDomain;
        }

        public UserEntity ToDomainModel(User user)
        {
            //Kako bez atributa za navigaciju saznati za usera njegova fav i sponsor mjesta?
            UserEntity userDomain = new UserEntity()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                FullName = user.FullName,
                IsActive = user.IsActive,
                UserTypeId = user.UserTypeId,
                FavoritePlaces = null,
                SponsorshipPlaces = null,
                Type = this.ToDomainModel(user.UserType)
            };

            return userDomain;
        }
        
        
        
        //To DAL
        public Category ToDALModel(CategoryEntity category)
        {
            Category categoryDAL = new Category()
            {
                Id = category.Id,
                Name = category.Name
            };

            return categoryDAL;
        }

        public Info ToDALModel(InfoEntity info)
        {
            Info infoDAL = new Info()
            {
                Time = info.time,
                CategoryId = info.categoryId,
                UserId = info.userId,
                PlaceId = info.placeId,
                Content = info.content,
                EndTime = info.endTime
            };

            return infoDAL;
        }

        public ReputationInfo ToDALModel(ReputationInfoEntity reputation)
        {
            ReputationInfo repInfoDAL = new ReputationInfo()
            {
                UserId = reputation.UserId,
                InfoId = reputation.ContentCommentId,
                Score = reputation.Score
            };

            return repInfoDAL;
        }

        public User ToDALModel(UserEntity user)
        {
            User userDAL = new User()
            {
                Username = user.Username,
                Password = user.Password,
                FullName = user.FullName,
                IsActive = user.IsActive,
                UserTypeId = user.UserTypeId
            };

            return userDAL;
        }

        public Place ToDALModel(PlaceEntity place)
        {
            Place placeDAL = new Place()
            {
                Name = place.Name,
                Location = DbGeography.PointFromText(String.Format("POINT({0} {1})", place.Location.Longitude, place.Location.Latitude), 4326)
            };

            return placeDAL;
        }
    }
}

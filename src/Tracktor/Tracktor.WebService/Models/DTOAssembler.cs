using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tracktor.Domain;

namespace Tracktor.WebService.Models
{
    public class DTOAssembler
    {
        //Create DTO objects
        public CommentDTO CreateCommentDTO(CommentEntity comment)
        {
            CommentDTO commentDTO = new CommentDTO()
            {
                Id = comment.Id,
                time = comment.EndTime,
                user = comment.user.FullName,
                content = comment.Content,
                reputation = comment.GetReputation()
            };

            return commentDTO;
        }
        public InfoDTO CreateInfoDTO(InfoEntity info)
        {
            List<CommentDTO> commentsList = new List<CommentDTO>();
            foreach (var com in info.comments)
            {
                commentsList.Add(this.CreateCommentDTO(com));
            }

            InfoDTO infoDTO = new InfoDTO()
            {
                Id = info.Id,
                startTime = info.time,
                endTime = info.endTime,
                content = info.content,
                category = info.category.Name,
                user = info.user.FullName,
                place = info.place.Name,
                reputation = info.GetReputation(),
                comments = commentsList
            };

            return infoDTO;
        }
        public UserDTO CreateUserDTO(UserEntity user)
        {
            UserDTO userDTO = new UserDTO()
            {
                Id = user.Id,
                FullName = user.FullName,
                IsActive = user.IsActive,
                UserTypeId = user.UserTypeId
            };

            return userDTO;
        }


        //Create Domain entities
        public CommentEntity CreateCommentEntity(CommentPostDTO comment)
        {
            CommentEntity commentDomain = new CommentEntity()
            {
                EndTime = comment.time,
                UserId = comment.userId,
                ContentInfoId = comment.contentInfoId,
                Content = comment.content
            };
            return commentDomain;
        }
        public InfoEntity CreateInfoEntity(InfoPostDTO info)
        {
            InfoEntity infoDomain = new InfoEntity()
            {
                time = info.startTime,
                endTime = info.endTime,
                content = info.content,
                categoryId = info.categoryId,
                userId = info.userId,
                placeId = info.placeId
            };
            return infoDomain;
        }
        public InfoEntity CreateInfoEntity(InfoPlacePostDTO info)
        {
            InfoEntity infoDomain = new InfoEntity()
            {
                time = info.startTime,
                endTime = info.endTime,
                content = info.content,
                categoryId = info.categoryId,
                userId = info.userId
            };
            return infoDomain;
        }
        public ReputationCommentEntity CreateReputationCommentEntity(RateCommentPostDTO reputation)
        {
            ReputationCommentEntity repInfo = new ReputationCommentEntity()
            {
                UserId = reputation.userId,
                ContentCommentId = reputation.commentId,
                Score = reputation.score
            };
            return repInfo;
        }
        public ReputationInfoEntity CreateReputationInfoEntity (RateInfoPostDTO reputation)
        {
            ReputationInfoEntity repInfo = new ReputationInfoEntity()
            {
                UserId = reputation.userId,
                ContentCommentId = reputation.infoId,
                Score = reputation.score
            };
            return repInfo;
        }
        public PlaceEntity CreatePlaceEntity(InfoPlacePostDTO info)
        {
            PlaceEntity placeDomain = new PlaceEntity()
            {
                Name = info.Name,
                Location = new GeoCoordinate(info.Latitude, info.Longitude)
            };
            return placeDomain;
        }
        public UserEntity CreateUserEntity(UserPostDTO user)
        {
            UserEntity userDomain = new UserEntity()
            {
                Username = user.Username,
                Password = user.Password,
                FullName = user.FullName,
                UserTypeId = user.UserTypeId,
                IsActive = false
            };
            return userDomain;
        }

    }
}
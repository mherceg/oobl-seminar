using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tracktor.Domain;

namespace Tracktor.WebService.Models
{
    public class DTOAssembler
    {
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
    }
}
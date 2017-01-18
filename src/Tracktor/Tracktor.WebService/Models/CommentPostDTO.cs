﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tracktor.WebService.Models
{
    public class CommentPostDTO
    {
        [Required]
        public System.DateTime time { get; set; }
        [Required]
        public int userId { get; set; }
        [Required]
        public int contentInfoId { get; set; }
        [Required]
        public string content { get; set; }
    }
}
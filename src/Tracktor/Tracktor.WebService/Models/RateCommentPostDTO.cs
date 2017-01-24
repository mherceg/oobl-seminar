﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tracktor.WebService.Models
{
    public class RateCommentPostDTO
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public int commentId { get; set; }
        [Required]
        public bool score { get; set; }
    }
}
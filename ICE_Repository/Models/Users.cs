﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        [JsonIgnore] public List<Comments> CommentId { get; set; } = new List<Comments>();
        [JsonIgnore] public List<UserDietaryPreferenceJOIN> UserDietaryPreferenceJOINs { get; set; } = new List<UserDietaryPreferenceJOIN>(); 
        [JsonIgnore] public List<Review> ReviewId { get; set; } = new List<Review>();
    }
}

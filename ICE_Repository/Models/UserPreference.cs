﻿using ICE_Repository.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICE_Repository.Models
{
    public class UserPreference
    {
        [Key]
        public int PreferenceId { get; set; }

        public Users UserId { get; set; }

        public string PreferenceType { get; set; }

        public string PreferenceDescription { get; set; }
    }
}
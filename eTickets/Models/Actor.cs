﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Full name must be between 6 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}

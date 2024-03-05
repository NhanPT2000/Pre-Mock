﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_Mock.Models.Users
{
    public class UserDetails
    {
        [Required]
        [Key]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "User name is required")]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Column(TypeName = "nvarchar(50)")]
        [Phone]
        public string Phone { get; set; }
        [DisplayFormat(NullDisplayText = "No status")]
        public string? Status { get; set; }

        public User User { get; set; }
    }
}

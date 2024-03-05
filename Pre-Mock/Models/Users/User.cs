﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_Mock.Models.Users
{
    public class User
    {
        [Key]
        [Required]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "User name is required.")]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        /*Verification need*/
        [Required(ErrorMessage = "Email is required.")]
        [Column(TypeName = "nvarchar(50)")]
        [EmailAddress]
        public string Email { get; set; }

    }
}

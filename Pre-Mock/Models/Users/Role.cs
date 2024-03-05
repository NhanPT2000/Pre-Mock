﻿using System.ComponentModel.DataAnnotations;

namespace Pre_Mock.Models.Users
{
    public class Role
    {
        [Required]
        [Key]
        public Guid RoleId { get; set; }
        [Required(ErrorMessage = "Role name is required.")]
        public string RoleName { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}

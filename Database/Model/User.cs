
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class User
    {
        [Key]
        public String UserId { get; set; }= Guid.NewGuid().ToString();
        [Required]
        public String? FullName { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? UserPassword { get; set; }
        [Required]
        public String? Email { get; set; }
        [Required]
        public String? Password { get; set; }
        public int? RoleId { get; set; }



    }
}

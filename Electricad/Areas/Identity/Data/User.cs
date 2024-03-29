﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Data
{
    public class User 
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = " The field Login is required")]
        public string login { get; set; }
        [Required(ErrorMessage = " The field Password is required")]
        public string password { get; set; }
        public  About About { get; set; }
        public ICollection<Offers> Offers { get; set; } = new List<Offers>();
        public ICollection<Portfolio> Portifolios { get; set; } = new List<Portfolio>();

      public User()
        {

        }

        public User(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }
    }
}

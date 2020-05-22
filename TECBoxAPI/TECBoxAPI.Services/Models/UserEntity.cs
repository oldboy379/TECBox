﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TECBoxAPI.Services.Models
{
    /**
     * Interfaz de estructura del Json de User.
     */
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

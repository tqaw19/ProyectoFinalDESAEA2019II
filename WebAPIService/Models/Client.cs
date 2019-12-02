﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIService.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string Category { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public List<int> MovieIds { get; set; }


    }
}
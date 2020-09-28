﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

  
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}
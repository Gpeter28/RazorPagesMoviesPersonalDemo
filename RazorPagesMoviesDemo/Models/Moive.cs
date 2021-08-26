﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMoviesDemo.Models
{
    public class Moive
    {
        public int ID { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

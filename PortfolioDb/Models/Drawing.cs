﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioDb.Models
{
    public class Drawing
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [MaxLength(120)]
        public string ImgUrl { get; set; }
        public DateTime DatePut { get; set; }
    }
}

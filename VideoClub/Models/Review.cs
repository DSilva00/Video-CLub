﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int MovieID { get; set; }
        public string Title{ get; set; }
        public string ReviewText{ get; set; }
        public int Rating { get; set; }


    }
}

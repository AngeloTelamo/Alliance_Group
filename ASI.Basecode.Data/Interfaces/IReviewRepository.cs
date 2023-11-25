﻿using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface IReviewRepository
    {
        bool ReviewUserExists(string reviewName);
        void AddReview(Review rev);
    }
}

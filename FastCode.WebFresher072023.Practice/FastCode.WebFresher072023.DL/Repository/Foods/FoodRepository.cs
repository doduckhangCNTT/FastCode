﻿using FastCode.WebFresher072023.DL.Entity;
using FastCode.WebFresher072023.DL.Repository.Bases;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.DL.Repository.Foods
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        public FoodRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}

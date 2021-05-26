﻿using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CollegeRepository : Repository<College>, ICollegeRepository
    {
        public CollegeRepository(VitalityDatabase vitalityDatabase) : base(vitalityDatabase)
        {
        }
    }
}

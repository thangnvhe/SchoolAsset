﻿using SchoolAsset.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.IRepository
{
    public interface IBuildingRepository : IGenericRepository<Building> 
    {
        void Update(Building building);
    }
}

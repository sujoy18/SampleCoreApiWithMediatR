﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.Core.DataLayer
{
  public  interface IEntityMap
    {
        void Map(ModelBuilder bulder);
    }
}

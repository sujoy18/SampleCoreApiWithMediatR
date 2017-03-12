using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.Core.DataLayer
{
   public  interface IAdventureLayerDataContext
    {
         string ConnectionString { get; }
         IEntityMapper EntityMapper { get; }
    }
}

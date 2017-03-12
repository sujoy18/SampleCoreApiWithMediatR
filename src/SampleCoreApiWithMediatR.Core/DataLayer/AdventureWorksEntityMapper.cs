using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.Core.DataLayer
{
    public class AdventureWorksEntityMapper: EntityMapper
    {
        public AdventureWorksEntityMapper()
        {
            Mappings = new List<IEntityMap>()
            {
                new ProductMap() as IEntityMap
            };
        }
    }
}

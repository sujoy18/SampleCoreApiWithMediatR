using Microsoft.EntityFrameworkCore;

namespace SampleCoreApiWithMediatR.Core.DataLayer
{
    public interface IEntityMapper 
    {
        void MapEntities(ModelBuilder modelBuilder);
    }
}
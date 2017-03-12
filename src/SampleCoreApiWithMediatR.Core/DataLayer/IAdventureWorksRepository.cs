using SampleCoreApiWithMediatR.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.Core.DataLayer
{
    public interface IAdventureWorksRepository
    {
        IQueryable<Product> GetProducts(Int32 pageSize, Int32 pageNumber, String name);

        Task<Product> GetProductAsync(Product entity);

        Task<Product> AddProductAsync(Product entity);

        Task<Product> UpdateProductAsync(Product changes);

        Task<Product> DeleteProductAsync(Product changes);
    }
}

using MediatR;
using SampleCoreApiWithMediatR.Core.DataLayer;
using SampleCoreApiWithMediatR.Core.EntityLayer;
using SampleCoreApiWithMediatR.Extensions;
using SampleCoreApiWithMediatR.Request;
using SampleCoreApiWithMediatR.Response;
using SampleCoreApiWithMediatR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.CommandHandler
{
    public class ProductCommandHandler : IRequestHandler<ProductRequest, IListModelResponse<ProductViewModel>>
    {
        private IAdventureWorksRepository _Repository;
        public ProductCommandHandler (IAdventureWorksRepository repository)
        {
            _Repository = repository;
        }
        public  IListModelResponse<ProductViewModel> Handle(ProductRequest message)
        {
            var response = new ListModelResponse<ProductViewModel>() as IListModelResponse<ProductViewModel>;

            try
            {
                response.PageNumber = message.PageNumber;
                response.PageSite = message.PageSize;
                response.Model = _Repository.GetProducts(message.PageSize, message.PageNumber, message.Name)
                                .Select(item => item.ToViewModel())
                                .ToList();

            }
            catch (Exception e)
            {
                response.DidError = true;
                response.Message = e.Message;
            }
            return response;
        }
    }
}

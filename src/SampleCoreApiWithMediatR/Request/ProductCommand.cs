using MediatR;
using SampleCoreApiWithMediatR.Response;
using SampleCoreApiWithMediatR.ViewModels;

namespace SampleCoreApiWithMediatR.Request
{
    public class ProductRequest:IRequest<IListModelResponse<ProductViewModel>>
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string Name { get; set; }
    }
}

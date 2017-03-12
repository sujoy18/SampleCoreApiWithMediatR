using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.Response
{
    public interface IListModelResponse<TModel>:IResponse
    {
        int PageNumber { get; set; }
        int PageSite { get; set; }
        IEnumerable<TModel> Model { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCoreApiWithMediatR.Core.DataLayer;
using SampleCoreApiWithMediatR.Response;
using SampleCoreApiWithMediatR.ViewModels;
using SampleCoreApiWithMediatR.Extensions;
using Microsoft.EntityFrameworkCore;
using MediatR;
using SampleCoreApiWithMediatR.Request;

namespace SampleCoreApiWithMediatR.Controllers
{
    [Route("api/[controller]")]
    public class ProductionController : Controller
    {
        IMediator _mediator;
        public ProductionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("products/PageSize/{pageSize}/PageNumber/{pageNumber}/Name/{name}")]
        public async Task<IActionResult> GetAllProducts(Int32 pageSize = 10, Int32 pageNumber = 1, String name = null)
        {
            ProductRequest productRequest = new ProductRequest
            {
                PageSize = pageSize,
                PageNumber = pageNumber,
                Name = name
            };
            var response = new ListModelResponse<ProductViewModel>() as IListModelResponse<ProductViewModel>;
            response = await _mediator.Send(productRequest);
            return response.ToHttpResponse();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.Response
{
    public interface IResponse
    {
        string Message { get; set; }
        bool DidError { get; set; }
        string ErrorMessage { get; set; }
    }
}

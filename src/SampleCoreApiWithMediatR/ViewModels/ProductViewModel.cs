using Microsoft.AspNetCore.Mvc;
using SampleCoreApiWithMediatR.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApiWithMediatR.ViewModels
{
    public class ProductViewModel
    {
       
        public Int32? ProductID { get; set; }

        public String ProductName { get; set; }

        public String ProductNumber { get; set; }

        
    }
}

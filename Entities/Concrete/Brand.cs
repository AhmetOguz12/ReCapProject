using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public  class Brand : IEntities
    {
        public string BrandName { get; set; }
        public int BrandId { get; set; }
    }
}

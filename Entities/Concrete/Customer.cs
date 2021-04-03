using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public int NationalIdentity { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
    }
}

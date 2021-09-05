using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Conrerte
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}

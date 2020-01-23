using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace First
{
    public class Customer : EntityBase
    {
        public string Description { get; set; }

        public Customer(IIdGenerator idGenerator) : base(idGenerator) { }
    }
}

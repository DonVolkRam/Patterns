using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator idGenerator;

        public long Id { get; private set; }

        public EntityBase(IIdGenerator IdGenerator)
        {
            idGenerator = IdGenerator ?? throw new ArgumentNullException();
            Id = idGenerator.CalculateId();
        }
    }
}

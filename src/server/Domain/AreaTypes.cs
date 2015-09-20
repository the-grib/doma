using System;
using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class AreaTypes : Entity
    {
        public AreaTypes(Guid id) : base(id)
        {
            Values = new List<AreaType>();
        }

        private AreaTypes() : this(Guid.Empty) { } // Only for EF!

        public List<AreaType> Values { get; }
    }
}
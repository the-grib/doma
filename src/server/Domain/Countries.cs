using System;
using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Countries : Entity
    {
        public Countries(Guid id) : base(id)
        {
            Values = new List<Country>();
        }

        private Countries() : this(Guid.Empty) { } // Only for EF!

        public List<Country> Values { get; }
    }
}
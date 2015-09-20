using System;
using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class CityStreets : Entity
    {
        public CityStreets(Guid id, City city) : base(id)
        {
            City = city;
            Values = new List<Street>();
        }

        private CityStreets() : this(Guid.Empty, null) { } // Only for EF!

        public City City { get; }

        public List<Street> Values { get; }
    }
}
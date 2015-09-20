using System;
using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class CountryCities : Entity
    {
        public CountryCities(Guid id, Country country) : base(id)
        {
            Country = country;
            Values = new List<City>();
        }

        private CountryCities() : this(Guid.Empty, null) { } // Only for EF!

        public Country Country { get; }

        public List<City> Values { get; }
    }
}
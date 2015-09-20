using System;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class House : Entity
    {
        public House(Guid id) : base(id) { }

        private House() : this(Guid.Empty) { } // Only for EF!

        public Country Country { get; set; }

        public City City { get; set; }

        public Street Street { get; set; }

        public string Number { get; set; }

        public int Storeys { get; set; }
    }
}
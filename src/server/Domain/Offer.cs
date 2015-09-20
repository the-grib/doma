using System;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Offer : Entity
    {
        public Offer(Guid id) : base(id) { }

        private Offer() : this(Guid.Empty) { } // Only for EF!

        public Guid? Landlord { get; set; }

        public Guid? Area { get; set; }

        public int Price { get; set; }

        public Conditions Conditions { get; set; }
    }
}
using System;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Area : Entity
    {
        public Area(Guid id) : base(id) { }

        private Area() : this(Guid.Empty) { } // Only for EF!

        public Guid? House { get; set; }

        public AreaType Type { get; set; }

        public int Storey { get; set; }

        public Space Space { get; set; }

        public string Notes { get; set; }

        //public Kitchen Kitchen { get; set; }

        //public Workplace Workplace { get; set; }

        //public Couchettes Couchettes { get; set; }

        //public Washroom Washroom { get; set; }

        //public Cleanliness Cleanliness { get; set; }
    }
}
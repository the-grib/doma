using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Couchettes : ValueObject
    {
        public Couchettes(bool bed, bool doubleBed, bool sofaBed, bool chairBed, bool mattress)
        {
            Bed = bed;
            DoubleBed = doubleBed;
            SofaBed = sofaBed;
            ChairBed = chairBed;
            Mattress = mattress;
        }

        private Couchettes() { } // Only for EF!

        public bool Bed { get; }

        public bool DoubleBed { get; }

        public bool SofaBed { get; }

        public bool ChairBed { get; }

        public bool Mattress { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Bed;
            yield return DoubleBed;
            yield return SofaBed;
            yield return ChairBed;
            yield return Mattress;
        }
    }
}
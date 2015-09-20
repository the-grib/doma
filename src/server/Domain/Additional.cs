using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Additional : ValueObject
    {
        public Additional(bool waterMeters, bool balcony, bool glazedBalcony, bool internet, bool tv, bool intercom)
        {
            WaterMeters = waterMeters;
            Balcony = balcony;
            GlazedBalcony = glazedBalcony;
            Internet = internet;
            Tv = tv;
            Intercom = intercom;
        }

        private Additional() { } // Only for EF!

        public bool WaterMeters { get; }

        public bool Balcony { get; }

        public bool GlazedBalcony { get; }

        public bool Internet { get; }

        public bool Tv { get; }

        public bool Intercom { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return WaterMeters;
            yield return Balcony;
            yield return GlazedBalcony;
            yield return Internet;
            yield return Tv;
            yield return Intercom;
        }
    }
}
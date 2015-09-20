using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Washroom : ValueObject
    {
        public Washroom(bool bathtub, bool shower, bool jacuzzi)
        {
            Bathtub = bathtub;
            Shower = shower;
            Jacuzzi = jacuzzi;
        }

        private Washroom() { } // Only for EF!

        public bool Bathtub { get; }

        public bool Shower { get; }

        public bool Jacuzzi { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Bathtub;
            yield return Shower;
            yield return Jacuzzi;
        }
    }
}
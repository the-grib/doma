using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Cleanliness : ValueObject
    {
        public Cleanliness(bool washingMachine, bool drier, bool iron, bool hoover)
        {
            WashingMachine = washingMachine;
            Drier = drier;
            Iron = iron;
            Hoover = hoover;
        }

        private Cleanliness() { } // Only for EF!

        public bool WashingMachine { get; }

        public bool Drier { get; }

        public bool Iron { get; }

        public bool Hoover { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return WashingMachine;
            yield return Drier;
            yield return Iron;
            yield return Hoover;
        }
    }
}
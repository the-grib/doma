using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Workplace : ValueObject
    {
        public Workplace(bool pc, bool desk, bool armchair, bool acoustics)
        {
            Pc = pc;
            Desk = desk;
            Armchair = armchair;
            Acoustics = acoustics;
        }

        private Workplace() { } // Only for EF!

        public bool Pc { get; }

        public bool Desk { get; }

        public bool Armchair { get; }

        public bool Acoustics { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Pc;
            yield return Desk;
            yield return Armchair;
            yield return Acoustics;
        }
    }
}
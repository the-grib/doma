using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Space : ValueObject
    {
        public Space(double common, double living, double cook)
        {
            Common = common;
            Living = living;
            Cook = cook;
        }

        private Space() { } // Only for EF!

        public double Common { get; }

        public double Living { get; }

        public double Cook { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Common;
            yield return Living;
            yield return Cook;
        }
    }
}
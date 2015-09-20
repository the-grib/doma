using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class City : ValueObject
    {
        public City(string name)
        {
            Name = name;
        }

        private City() : this(string.Empty) { } // Only for EF!

        public string Name { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
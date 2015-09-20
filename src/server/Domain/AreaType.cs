using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class AreaType : ValueObject
    {
        public AreaType(string name)
        {
            Name = name;
        }

        private AreaType() { } // Only for EF!

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
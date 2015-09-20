using System;

namespace Todom.Infrastructure.Domain
{
    public abstract class Enumeration : Entity
    {
        protected Enumeration(Guid id) : base(id) { }

        public string Name { get; private set; }
    }
}
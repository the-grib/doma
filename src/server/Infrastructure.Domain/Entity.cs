using System;
using System.Collections.Generic;

namespace Todom.Infrastructure.Domain
{
    public abstract class Entity : DomainObject
    {
        protected Entity(Guid id) : base(id) { }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
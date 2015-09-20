using System;

namespace Todom.Infrastructure.Domain
{
    public abstract class ValueObject : DomainObject
    {
        protected ValueObject() : base(Guid.NewGuid()) { }
    }
}
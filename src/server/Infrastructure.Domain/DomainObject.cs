using System;
using System.Collections.Generic;
using System.Linq;

namespace Todom.Infrastructure.Domain
{
    public abstract class DomainObject : IEquatable<DomainObject>
    {
        protected DomainObject(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }

        public bool Equals(DomainObject other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            var components = GetIdentityComponents();
            var otherComponents = other.GetIdentityComponents();
            return components.SequenceEqual(otherComponents);
        }

        /// <summary>
        ///     When overriden in a derived class, returns all components which constitute identity.
        /// </summary>
        /// <returns>An ordered list of identity components.</returns>
        protected abstract IEnumerable<object> GetIdentityComponents();

        public override bool Equals(object other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return Equals((DomainObject) other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                foreach (var component in GetIdentityComponents())
                    hash = hash*23 + (component != null ? component.GetHashCode() : 0);
                return hash;
            }
        }

        public static bool operator ==(DomainObject left, DomainObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DomainObject left, DomainObject right)
        {
            return !Equals(left, right);
        }
    }
}
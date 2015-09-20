using System;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Person : Entity
    {
        public Person(Guid id) : base(id) { }

        private Person() : this(Guid.Empty) { } // Only for EF!

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
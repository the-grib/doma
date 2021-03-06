﻿using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Street : ValueObject
    {
        public Street(string name)
        {
            Name = name;
        }

        private Street() { } // Only for EF!

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
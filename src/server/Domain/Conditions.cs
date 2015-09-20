using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Conditions : ValueObject
    {
        public Conditions(bool paymentOfUtilitiesIncluded, bool plusPaymentForElectricity, bool plusPaymentForWater,
            bool smokingAllowed, bool petsAllowed, bool familyKidFriendly,
            bool nationalityIsNotImportant)
        {
            PaymentOfUtilitiesIncluded = paymentOfUtilitiesIncluded;
            PlusPaymentForElectricity = plusPaymentForElectricity;
            PlusPaymentForWater = plusPaymentForWater;
            SmokingAllowed = smokingAllowed;
            PetsAllowed = petsAllowed;
            FamilyKidFriendly = familyKidFriendly;
            NationalityIsNotImportant = nationalityIsNotImportant;
        }

        private Conditions() { } // Only for EF!

        public bool PaymentOfUtilitiesIncluded { get; }

        public bool PlusPaymentForElectricity { get; }

        public bool PlusPaymentForWater { get; }

        public bool SmokingAllowed { get; }

        public bool PetsAllowed { get; }

        public bool FamilyKidFriendly { get; }

        public bool NationalityIsNotImportant { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return PaymentOfUtilitiesIncluded;
            yield return PlusPaymentForElectricity;
            yield return PlusPaymentForWater;
            yield return SmokingAllowed;
            yield return PetsAllowed;
            yield return FamilyKidFriendly;
            yield return NationalityIsNotImportant;
        }
    }
}
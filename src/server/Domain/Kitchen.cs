using System.Collections.Generic;
using Todom.Infrastructure.Domain;

namespace Todom.Domain
{
    public class Kitchen : ValueObject
    {
        public Kitchen(bool kitchenCabinets, bool dinnerTable, bool fridge, bool cooker, bool microwave, bool dishwasher,
            bool teapot, bool cutleryAndCrockery)
        {
            KitchenCabinets = kitchenCabinets;
            DinnerTable = dinnerTable;
            Fridge = fridge;
            Cooker = cooker;
            Microwave = microwave;
            Dishwasher = dishwasher;
            Teapot = teapot;
            CutleryAndCrockery = cutleryAndCrockery;
        }

        private Kitchen() { } // Only for EF!

        public bool KitchenCabinets { get; }

        public bool DinnerTable { get; }

        public bool Fridge { get; }

        public bool Cooker { get; }

        public bool Microwave { get; }

        public bool Dishwasher { get; }

        public bool Teapot { get; }

        public bool CutleryAndCrockery { get; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return KitchenCabinets;
            yield return DinnerTable;
            yield return Fridge;
            yield return Cooker;
            yield return Microwave;
            yield return Dishwasher;
            yield return Teapot;
            yield return CutleryAndCrockery;
        }
    }
}
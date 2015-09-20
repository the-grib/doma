using System;
using System.Web.Http;

namespace Todom.Facade.Controllers.Area
{
    public partial class OfferController : ApiController
    {
        public ViewModel Get(Guid id)
        {
            var house = new Domain.House(Guid.NewGuid())
            {
                Country = new Domain.Country("Россия"),
                City = new Domain.City("Томск"),
                Street = new Domain.Street("ул. 79 гвардейской дивизии"),
                Number = "59/1",
                Storeys = 10
            };
            var area = new Domain.Area(Guid.NewGuid())
            {
                Space = new Domain.Space(0, 0, 0),
                House = house.Id,
                Storey = 9,
                Type = new Domain.AreaType("1-комн."),
                Notes =
                    "Апартаменты расположены на девятом этаже кирпичной новостройки в центре города. Рядом с домом находится главный корпус ТПУ, пр.Ленина(700 м.), Институт неразрушающего контроля, СибГМУ, Госпитальные клиники им.А.Г.Савиных"
            };
            var landlord = new Domain.Person(Guid.NewGuid()) {FirstName = "Иван", LastName = "Гринько"};
            var offer = new Domain.Offer(Guid.NewGuid()) {Area = area.Id, Landlord = landlord.Id, Price = 15000};

            var storey = $"{area.Storey}/{house.Storeys} этаж";
            var data = new ViewModel
            {
                Photo = "7507C59B-A983-4F21-A70D-B352FAC7ADEE",
                Price = $"{offer.Price} руб./мес.",
                AddressLine1 = string.Join(", ", house.Street, house.Number),
                AddressLine2 = string.Join(", ", house.City, storey),
                Landlord = landlord.FirstName,
                Type = area.Type.Name,
                Notes = area.Notes,
                Conditions = new Conditions(),
                Properties = new Properties
                {
                    Kitchen = new Kitchen(),
                    Workplace = new Workplace(),
                    Couchettes = new Couchettes(),
                    Washroom = new Washroom(),
                    Cleanliness = new Cleanliness(),
                    Additional = new Additional()
                }
            };
            return data;
        }
    }

    public class ViewModel
    {
        public string Photo { get; set; }

        public string Price { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Landlord { get; set; }

        public string Type { get; set; }

        public string Notes { get; set; }

        public Conditions Conditions { get; set; }

        public Properties Properties { get; set; }
    }

    public class Properties
    {
        public Kitchen Kitchen { get; set; }

        public Workplace Workplace { get; set; }

        public Couchettes Couchettes { get; set; }

        public Washroom Washroom { get; set; }

        public Cleanliness Cleanliness { get; set; }

        public Additional Additional { get; set; }
    }

    public class Kitchen
    {
        public bool KitchenCabinets { get; set; }

        public bool DinnerTable { get; set; }

        public bool Fridge { get; set; }

        public bool Cooker { get; set; }

        public bool Microwave { get; set; }

        public bool Dishwasher { get; set; }

        public bool Teapot { get; set; }

        public bool CutleryAndCrockery { get; set; }
    }

    public class Workplace
    {
        public bool Pc { get; set; }

        public bool Desk { get; set; }

        public bool Armchair { get; set; }

        public bool Acoustics { get; set; }
    }

    public class Couchettes
    {
        public bool Bed { get; set; }

        public bool DoubleBed { get; set; }

        public bool SofaBed { get; set; }

        public bool ChairBed { get; set; }

        public bool Mattress { get; set; }
    }

    public class Washroom
    {
        public bool Bathtub { get; set; }

        public bool Shower { get; set; }

        public bool Jacuzzi { get; set; }
    }

    public class Cleanliness
    {
        public bool WashingMachine { get; set; }

        public bool Drier { get; set; }

        public bool Iron { get; set; }

        public bool Hoover { get; set; }
    }

    public class Additional
    {
        public bool WaterMeters { get; set; }

        public bool Balcony { get; set; }

        public bool GlazedBalcony { get; set; }

        public bool Internet { get; set; }

        public bool Tv { get; set; }

        public bool ElevatorInBuilding { get; set; }

        public bool Intercom { get; set; }
    }

    public class Conditions
    {
        public bool PaymentOfUtilitiesIncluded { get; set; }

        public bool PlusPaymentForElectricity { get; set; }

        public bool PlusPaymentForWater { get; set; }

        public bool SmokingAllowed { get; set; }

        public bool PetsAllowed { get; set; }

        public bool FamilyKidFriendly { get; set; }

        public bool NationalityIsNotImportant { get; set; }
    }
}
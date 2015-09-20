using System;
using System.Web.Http;
using Todom.Domain;

namespace Todom.Facade.Controllers.Area
{
    public partial class AreaController : ApiController
    {
        public AreaView Get(Guid id)
        {
            var house = new House(Guid.NewGuid())
            {
                Country = new Country("Россия"),
                City = new City("Томск"),
                Street = new Street("ул. 79 гвардейской дивизии"),
                Number = "59/1",
                Storeys = 10
            };
            var area = new Domain.Area(Guid.NewGuid())
            {
                Space = new Space(0, 0, 0),
                House = house.Id,
                Storey = 9,
                Type = new AreaType("1-комн."),
                Notes =
                    "Апартаменты расположены на девятом этаже кирпичной новостройки в центре города. Рядом с домом находится главный корпус ТПУ, пр.Ленина(700 м.), Институт неразрушающего контроля, СибГМУ, Госпитальные клиники им.А.Г.Савиных"
            };
            var landlord = new Person(Guid.NewGuid()) {FirstName = "Иван", LastName = "Гринько"};
            var offer = new Offer(Guid.NewGuid()) {Area = area.Id, Landlord = landlord.Id, Price = 15000};

            var storey = $"{area.Storey}/{house.Storeys} этаж";
            var view = new AreaView
            {
                Price = $"{offer.Price} руб./мес.",
                Landlord = landlord.FirstName,
                AddressLine1 = string.Join(", ", house.Street, house.Number),
                AddressLine2 = string.Join(", ", house.City, storey),
                Type = area.Type.Name,
                Notes = area.Notes
            };
            return view;
        }
    }

    public class AreaView
    {
        public string Price { get; set; }

        public string Landlord { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Type { get; set; }

        public string Notes { get; set; }
    }
}
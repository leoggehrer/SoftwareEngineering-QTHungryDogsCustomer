using QTHungryDogsCustomer.Logic.Models.OpeningHour;
using QTHungryDogsCustomer.Logic.Modules.Common;

namespace QTHungryDogsCustomer.Logic.ServiceModels.Base
{
    public class Restaurant : VersionService
    {
        public string DisplayName { get; set; } = String.Empty;
        public string OwnerName { get; set; } = String.Empty;
        public string UniqueName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string AddressStreet { get; set; } = String.Empty;
        public string AddressHousenumber { get; set; } = String.Empty;
        public string AddressZipcode { get; set; } = String.Empty;
        public string AddressCity { get; set; } = String.Empty;
        public OpenState OpenState { get; set; }
        public RestaurantState State { get; set; }

        // Navigation properties
        public List<OpeningHour> OpeningHours { get; set; } = new();
    }
}

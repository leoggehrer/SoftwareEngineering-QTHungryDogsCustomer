using QTHungryDogsCustomer.Logic.Modules.Common;
using QTHungryDogsCustomer.Logic.ServiceModels;

namespace QTHungryDogsCustomer.Logic.Models.OpeningHour
{
    public class OpeningHour : VersionService
    {
        public int RestaurantId { get; set; }
        public Weekday Weekday { get; set; }
        public TimeSpan OpenFrom { get; set; }
        public TimeSpan OpenTo { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; } = true;
    }
}


using QTHungryDogsCustomer.Logic.Modules.Common;

namespace QTHungryDogsCustomer.Logic.ServiceModels.Base
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

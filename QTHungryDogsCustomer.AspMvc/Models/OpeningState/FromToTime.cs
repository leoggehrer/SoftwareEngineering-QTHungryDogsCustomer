using QTHungryDogsCustomer.Logic.Modules.Common;

namespace QTHungryDogsCustomer.AspMvc.Models.OpeningState
{
    /// <summary>
    /// Represents a class for representing a time span and its status.
    /// </summary>
    public class FromToTime
    {
        /// <summary>
        /// Gets and sets from value.
        /// </summary>
        public DateTime From { get; set; }
        /// <summary>
        /// Gets and sets to value.
        /// </summary>
        public DateTime To { get; set; }
        /// <summary>
        /// Gets and sets the time span state.
        /// </summary>
        public OpenState State { get; set; }

        public bool IsBetween(DateTime date)
        {
            var fromStamp = From.GetDateSecondStamp();
            var dateStamp = date.GetDateSecondStamp();
            var toStamp = To.GetDateSecondStamp();

            return fromStamp <= dateStamp && dateStamp <= toStamp;
        }
    }
}

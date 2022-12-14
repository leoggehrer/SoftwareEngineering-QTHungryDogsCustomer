//@GeneratedCode
namespace QTHungryDogsCustomer.Logic.Services.Base
{
    ///
    /// Generated by the generator
    ///
    public sealed partial class RestaurantsService : Services.GenericService<ServiceModels.Base.Restaurant>, Contracts.Base.IRestaurantsService<ServiceModels.Base.Restaurant>
    {
        private static string ServiceBaseAddress = "https://localhost:7085/api";
        private static string ServiceRequestUri = "Restaurants";
        ///
        /// Generated by the generator
        ///
        static RestaurantsService()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public RestaurantsService()
        : base(ServiceBaseAddress, ServiceRequestUri)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
    }
}

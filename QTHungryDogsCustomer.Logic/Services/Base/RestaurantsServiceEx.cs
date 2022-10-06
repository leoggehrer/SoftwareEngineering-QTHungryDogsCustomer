using QTHungryDogsCustomer.Logic.Modules.RestApi;
using QTHungryDogsCustomer.Logic.ServiceModels.Base;

namespace QTHungryDogsCustomer.Logic.Services.Base
{
    partial class RestaurantsService
    {
        static partial void ClassConstructed()
        {
        }
        public async Task<Restaurant[]> QueryRestaurantInfosAsync(string? predicate, string? orderBy)
        {
            var clientAccess = new ClientAccess(BaseAddress, SessionToken);
            var result = await clientAccess.GetAsync<Restaurant>($"RestaurantInfos/QueryInfos?{nameof(predicate)}={predicate}&{nameof(orderBy)}={orderBy}").ConfigureAwait(false);

            return result ?? Array.Empty<Restaurant>();
        }

        /// <summary>
        /// Returns the element of type T with the identification of id.
        /// </summary>
        /// <param name="id">The identification.</param>
        /// <returns>The element of the type T with the corresponding identification.</returns>
        public override async Task<Restaurant?> GetByIdAsync(int id)
        {
            var clientAccess = new ClientAccess(BaseAddress, SessionToken);
            var result = await clientAccess.GetByIdAsync<Restaurant>("RestaurantInfos", id);

            return result;
        }
    }
}

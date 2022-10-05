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
    }
}

using QTHungryDogsCustomer.Logic.ServiceModels.Base;

namespace QTHungryDogsCustomer.Logic.Contracts.Base
{
    partial interface IRestaurantsService<T>
    {
        Task<Restaurant[]> QueryRestaurantInfosAsync(string? predicate, string? orderBy);
    }
}

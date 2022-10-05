//@CodeCopy
//MdStart
namespace QTHungryDogsCustomer.WebApi
{
    /// <summary>
    /// Extension Program
    /// </summary>
    public partial class Program
    {
        /// <summary>
        /// Services can be added using this method.
        /// </summary>
        /// <param name="builder">The builder</param>
        public static void BeforeBuild(WebApplicationBuilder builder)
        {
#if ACCOUNT_ON
            builder.Services.AddTransient<QTHungryDogsCustomer.Logic.Contracts.Account.IIdentitiesAccess<QTHungryDogsCustomer.Logic.Models.Account.Identity>, QTHungryDogsCustomer.Logic.Facades.Account.IdentitiesFacade>();
            builder.Services.AddTransient<QTHungryDogsCustomer.Logic.Contracts.Account.IRolesAccess<QTHungryDogsCustomer.Logic.Models.Account.Role>, QTHungryDogsCustomer.Logic.Facades.Account.RolesFacade>();
            builder.Services.AddTransient<QTHungryDogsCustomer.Logic.Contracts.Account.IUsersAccess<QTHungryDogsCustomer.Logic.Models.Account.User>, QTHungryDogsCustomer.Logic.Facades.Account.UsersFacade>();
#endif
            AddServices(builder);
        }
        /// <summary>
        /// Configures can be added using this method.
        /// </summary>
        /// <param name="app"></param>
        public static void AfterBuild(WebApplication app)
        {
            AddConfigures(app);
        }
        static partial void AddServices(WebApplicationBuilder builder);
        static partial void AddConfigures(WebApplication app);
    }
}
//MdEnd

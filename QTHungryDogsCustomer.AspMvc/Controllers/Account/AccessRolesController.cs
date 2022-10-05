﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTHungryDogsCustomer.AspMvc.Controllers.Account
{
    using TAccessModel = QTHungryDogsCustomer.Logic.Models.Account.Role;
    using TViewModel = QTHungryDogsCustomer.AspMvc.Models.Account.AccessRole;
    using TFilterModel = QTHungryDogsCustomer.AspMvc.Models.Account.AccessRoleFilter;
    using TAccessContract = QTHungryDogsCustomer.Logic.Contracts.Account.IRolesAccess<QTHungryDogsCustomer.Logic.Models.Account.Role>;

    public partial class AccessRolesController : Controllers.FilterGenericController<TAccessModel, TViewModel, TFilterModel, TAccessContract>
    {
        ///
        /// Generated by the generator
        ///
        static AccessRolesController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        protected override string ControllerName => "AccessRoles";
        ///
        /// Generated by the generator
        ///
        public AccessRolesController(TAccessContract other)
        : base(other)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        protected override TViewModel ToViewModel(TAccessModel accessModel, ActionMode actionMode)
        {
            var handled = false;
            var result = default(TViewModel);
            BeforeToViewModel(accessModel, actionMode, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = TViewModel.Create(accessModel);
            }
            AfterToViewModel(result, actionMode);
            return BeforeView(result, actionMode);
        }
        partial void BeforeToViewModel(TAccessModel accessModel, ActionMode actionMode, ref TViewModel? viewModel, ref bool handled);
        partial void AfterToViewModel(TViewModel viewModel, ActionMode actionMode);
    }
}
#endif
//MdEnd
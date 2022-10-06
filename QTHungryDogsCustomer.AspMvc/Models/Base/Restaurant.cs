//@GeneratedCode
namespace QTHungryDogsCustomer.AspMvc.Models.Base
{
    using System;

    ///
    /// Generated by the generator
    ///
    public partial class Restaurant
    {
        ///
        /// Generated by the generator
        ///
        static Restaurant()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public Restaurant()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public System.String DisplayName
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String OwnerName
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String UniqueName
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String Email
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String AddressStreet
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String AddressHousenumber
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String AddressZipcode
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String AddressCity
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public QTHungryDogsCustomer.Logic.Modules.Common.OpenState OpenState
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTHungryDogsCustomer.Logic.Modules.Common.RestaurantState State
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Collections.Generic.List<Logic.Models.OpeningHour.OpeningHour> OpeningHours
        {
            get;
            set;
        }
        = new();
        ///
        /// Generated by the generator
        ///
        public static QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant Create()
        {
            BeforeCreate();
            var result = new QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant Create(QTHungryDogsCustomer.Logic.ServiceModels.Base.Restaurant other)
        {
            BeforeCreate(other);
            var result = new QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTHungryDogsCustomer.Logic.ServiceModels.Base.Restaurant other);
        static partial void AfterCreate(QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant instance, QTHungryDogsCustomer.Logic.ServiceModels.Base.Restaurant other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTHungryDogsCustomer.Logic.ServiceModels.Base.Restaurant other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                DisplayName = other.DisplayName;
                OwnerName = other.OwnerName;
                UniqueName = other.UniqueName;
                Email = other.Email;
                AddressStreet = other.AddressStreet;
                AddressHousenumber = other.AddressHousenumber;
                AddressZipcode = other.AddressZipcode;
                AddressCity = other.AddressCity;
                OpenState = other.OpenState;
                State = other.State;
                OpeningHours = other.OpeningHours;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTHungryDogsCustomer.Logic.ServiceModels.Base.Restaurant other, ref bool handled);
        partial void AfterCopyProperties(QTHungryDogsCustomer.Logic.ServiceModels.Base.Restaurant other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                DisplayName = other.DisplayName;
                OwnerName = other.OwnerName;
                UniqueName = other.UniqueName;
                Email = other.Email;
                AddressStreet = other.AddressStreet;
                AddressHousenumber = other.AddressHousenumber;
                AddressZipcode = other.AddressZipcode;
                AddressCity = other.AddressCity;
                OpenState = other.OpenState;
                State = other.State;
                OpeningHours = other.OpeningHours;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant other, ref bool handled);
        partial void AfterCopyProperties(QTHungryDogsCustomer.AspMvc.Models.Base.Restaurant other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.Restaurant other)
            {
                result = IsEqualsWith(RowVersion, other.RowVersion)
                && Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(DisplayName, OwnerName, UniqueName, Email, AddressStreet, AddressHousenumber, HashCode.Combine(AddressZipcode, AddressCity, OpenState, State, OpeningHours, RowVersion, HashCode.Combine(Id)));
        }
    }
}

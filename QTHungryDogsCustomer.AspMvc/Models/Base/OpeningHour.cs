//@GeneratedCode
namespace QTHungryDogsCustomer.AspMvc.Models.Base
{
    using System;

    ///
    /// Generated by the generator
    ///
    public partial class OpeningHour
    {
        ///
        /// Generated by the generator
        ///
        static OpeningHour()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public OpeningHour()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public System.Int32 RestaurantId
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTHungryDogsCustomer.Logic.Modules.Common.Weekday Weekday
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.TimeSpan OpenFrom
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.TimeSpan OpenTo
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.String? Notes
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Boolean IsActive
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public static QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour Create()
        {
            BeforeCreate();
            var result = new QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour Create(Logic.Models.OpeningHour.OpeningHour other)
        {
            BeforeCreate(other);
            var result = new QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(Logic.Models.OpeningHour.OpeningHour other);
        static partial void AfterCreate(QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour instance, Logic.Models.OpeningHour.OpeningHour other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(Logic.Models.OpeningHour.OpeningHour other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                RestaurantId = other.RestaurantId;
                Weekday = other.Weekday;
                OpenFrom = other.OpenFrom;
                OpenTo = other.OpenTo;
                Notes = other.Notes;
                IsActive = other.IsActive;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(Logic.Models.OpeningHour.OpeningHour other, ref bool handled);
        partial void AfterCopyProperties(Logic.Models.OpeningHour.OpeningHour other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                RestaurantId = other.RestaurantId;
                Weekday = other.Weekday;
                OpenFrom = other.OpenFrom;
                OpenTo = other.OpenTo;
                Notes = other.Notes;
                IsActive = other.IsActive;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour other, ref bool handled);
        partial void AfterCopyProperties(QTHungryDogsCustomer.AspMvc.Models.Base.OpeningHour other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.OpeningHour other)
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
            return HashCode.Combine(RestaurantId, Weekday, OpenFrom, OpenTo, Notes, IsActive, HashCode.Combine(RowVersion, Id));
        }
    }
}

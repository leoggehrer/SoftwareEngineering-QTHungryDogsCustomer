﻿//@CodeCopy
//MdStart
using QTHungryDogsCustomer.Logic.Contracts;
using System.ComponentModel.DataAnnotations;

namespace QTHungryDogsCustomer.WebApi.Models
{
    /// <summary>
    /// The model with the version property.
    /// </summary>
    public abstract partial class VersionModel : IdentityModel, IVersionable
    {
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
//MdEnd

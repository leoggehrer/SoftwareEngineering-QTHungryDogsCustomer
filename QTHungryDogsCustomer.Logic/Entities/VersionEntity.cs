//@CodeCopy
//MdStart

using QTHungryDogsCustomer.Logic.Contracts;

namespace QTHungryDogsCustomer.Logic.Entities
{
    public abstract partial class VersionEntity : IdentityEntity, IVersionable
    {
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        [Timestamp]
        public byte[]? RowVersion { get; internal set; }
    }
}
//MdEnd

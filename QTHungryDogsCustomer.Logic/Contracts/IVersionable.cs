//@CodeCopy
//MdStart

namespace QTHungryDogsCustomer.Logic.Contracts
{
    public partial interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd

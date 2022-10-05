//@CodeCopy
//MdStart
#if ACCOUNT_ON && LOGGING_ON
using QTHungryDogsCustomer.Logic.Entities.Logging;

namespace QTHungryDogsCustomer.Logic.Controllers.Logging
{
    internal sealed partial class ActionLogsController : GenericController<ActionLog>
    {
        public ActionLogsController()
        {
        }

        public ActionLogsController(ControllerObject other) : base(other)
        {
        }
    }
}
#endif
//MdEnd

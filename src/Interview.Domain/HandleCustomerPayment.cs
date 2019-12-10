using Interview.Domain.Infrastructure;

namespace Interview.Domain
{
    public class HandleCustomer
    {
        public Logger Logger { get; set; }

        public HandleCustomer()
        {
            Logger = ServiceLocator.LocateService<Logger>();
        }
    }
}

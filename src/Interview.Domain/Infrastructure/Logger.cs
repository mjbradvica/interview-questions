using System.Threading.Tasks;

namespace Interview.Domain.Infrastructure
{
    public class Logger
    {
        public Task LogMessage(string message)
        {
            //Pretend logging happened. 
            return Task.CompletedTask;
        }
    }
}

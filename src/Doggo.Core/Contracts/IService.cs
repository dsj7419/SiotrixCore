using System.Threading.Tasks;

namespace Doggo
{
    public interface IService
    {
        Task StartAsync();
        Task StopAsync();
    }
}

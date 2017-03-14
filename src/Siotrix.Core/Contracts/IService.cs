using System.Threading.Tasks;

namespace Siotrix
{
    public interface IService
    {
        Task StartAsync();
        Task StopAsync();
    }
}

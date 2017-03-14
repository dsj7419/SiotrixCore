using System;
using System.Threading.Tasks;

namespace Siotrix
{
    public class GlobalErrorHandler : IService
    {
        public Task StartAsync()
        {
            AppDomain.CurrentDomain.UnhandledException += OnException;
            return Task.CompletedTask;
        }

        public Task StopAsync()
        {
            AppDomain.CurrentDomain.UnhandledException -= OnException;
            return Task.CompletedTask;
        }

        private async void OnException(object sender, UnhandledExceptionEventArgs e)
            => await OnExceptionAsync(sender, e);
        private async Task OnExceptionAsync(object s, UnhandledExceptionEventArgs e)
        {
            var ex = (Exception)e.ExceptionObject;
            var error = new Error(ex);

            using (var db = new LogDatabase())
            {
                await db.Errors.AddAsync(error);
                await db.SaveChangesAsync();
            }
        }
    }
}

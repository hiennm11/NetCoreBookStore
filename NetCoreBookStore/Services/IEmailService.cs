using NetCoreBookStore.Models;
using System.Threading.Tasks;

namespace NetCoreBookStore.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
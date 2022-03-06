using MyOfficeSpace.Domain.Settings;
using System.Threading.Tasks;

namespace MyOfficeSpace.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}

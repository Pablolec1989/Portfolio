using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IServiceEmail
    {
        Task EnviarEmail(ContactoViewModel contactoViewModel);
    }
}

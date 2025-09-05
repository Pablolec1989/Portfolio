using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IRepositoryProjects
    {
        List<ProyectoViewModel> ObtenerProyectos();
    }
}

using Portfolio.Models;

namespace Portfolio.Services
{
    public class RepositoryProjects : IRepositoryProjects
    {
        public List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>
            {
                new ProyectoViewModel
                {
                    Titulo = "GESTOR DE PRODUCTOS",
                    Descripcion = "Desarrollo de una aplicación de escritorio (WinForms) para la gestión de productos, incorporando operaciones CRUD completas y persistencia de información en base de datos SQL Server",
                    ImagenUrl = "",
                    Link = "https://github.com/Pablolec1989/Catalogo-de-productos"
                },
                new ProyectoViewModel
                {
                    Titulo = "CATÁLOGO WEB DE PRODUCTOS",
                    Descripcion = " Desarrollo de una WebApp funcional para la gestión de productos, incluyendo operaciones CRUD completas y persistencia de datos en base de datos SQL Server",
                    ImagenUrl = "",
                    Link = "https://github.com/Pablolec1989/Tp-final-nivel3-Leccese-Pablo"
                },
                new ProyectoViewModel
                {
                    Titulo = "APLICACIÓN WEB PELÍCULAS",
                    Descripcion = "Desarrollo de una aplicación web para la gestión de una colección de películas, utilizando ASP.NET Core MVC y Entity Framework Core para operaciones CRUD y persistencia en base de datos SQL Server",
                    ImagenUrl = "",
                    Link = "https://github.com/Pablolec1989/PeliculasAPI"
                },
                new ProyectoViewModel
                {
                    Titulo = "APLICACIÓN GESTIÓN DE ALUMNOS PILATES",
                    Descripcion = "Implementación de una aplicación web completa que digitaliza y optimiza la administración de alumnos, instructores, turnos y gestión de pagos para un estudio de Pilates.",
                    ImagenUrl = "",
                    Link = "https://github.com/Pablolec1989/AmoPilatesAPI"
                },
                new ProyectoViewModel
                {
                    Titulo = "CALCULADORA COMPARATIVA DE COSTOS",
                    Descripcion = "Desarrollo colaborativo y despliegue de una aplicación web pública para una empresa de insumos médicos. La solución permite una comparativa de precios y rendimiento entre un producto concentrado propio y productos de la competencia, basada en requisitos de negocio específicos.",
                    ImagenUrl = "",
                    Link = "https://github.com/Pablolec1989/CalculadoraRendimientoProductos"
                },
                new ProyectoViewModel
                {
                    Titulo = "PROYECTO DE CRM (Customer Relationship Management)",
                    Descripcion = "Desarrollo colaborativo de una aplicación web para pequeña empresa que consta en nuclear todas las interacciones relacionadas a los empleados y clientes.",
                    ImagenUrl = "",
                    Link = "https://github.com/Pablolec1989/ProyectCRM"
                },
            };
        }
    }
}

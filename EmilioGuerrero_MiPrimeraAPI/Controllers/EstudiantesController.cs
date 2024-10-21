using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmilioGuerrero_MiPrimeraAPI.Modelos;

namespace EmilioGuerrero_MiPrimeraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        public Estudiante GetDevuelveInformacionEstudiante()
        {
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Emilio",
                Edad = 19,
            };
            return estudiante;

        }
    }
}

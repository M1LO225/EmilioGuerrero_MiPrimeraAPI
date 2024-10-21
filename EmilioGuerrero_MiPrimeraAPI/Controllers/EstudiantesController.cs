using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmilioGuerrero_MiPrimeraAPI.Modelos;
using EmilioGuerrero_MiPrimeraAPI.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace EmilioGuerrero_MiPrimeraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        [Route("InformacionEstudiante")]
        [HttpGet]
        public ActionResult DevuelveInformacionEstudiante(int id)
        {
            try
            {
                EstudianteRepository repositorio = new EstudianteRepository();
                if (id == 0) 
                {
                    return NotFound();
                    
                }
                var estudiante = repositorio.DevuelveInformacionEstudiante();
                return Ok(estudiante);
            }
            catch(Exception)
            {
                return BadRequest();
            }
          

        }

        [Route("ListadoEstudiantes")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            EstudianteRepository repositorio = new EstudianteRepository();
            return repositorio.DevuelveListadoEstudiantes();

        }

        [Route("ListadoEstudiantesPorNombre/{nombre}")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantesPorNombre(string nombre)
        {
            EstudianteRepository repositorio = new EstudianteRepository();
            return repositorio.DevuelveListadoEstudiantes().Where(x => x.Nombre == nombre).ToList();
        }
            
    }
}

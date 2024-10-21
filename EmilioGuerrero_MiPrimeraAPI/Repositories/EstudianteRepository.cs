using EmilioGuerrero_MiPrimeraAPI.Modelos;

namespace EmilioGuerrero_MiPrimeraAPI.Repositories
{
    public class EstudianteRepository
    {
        public Estudiante DevuelveInformacionEstudiante() 
        {
            Estudiante estudiante = new Estudiante

            {
                Id = 1,
                Nombre = "Emilio",
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true,
                Edad = 19,
            };
            return estudiante;
        }

        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(new Estudiante
            {
                Id = 1,
                Nombre = "Emilio",
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true,
                Edad = 19,
            });
            estudiantes.Add(new Estudiante
            {
                Id = 2,
                Nombre = "Esteban",
                FechaNacimiento = DateTime.Now,
                EstaInscrito = false,
                Edad = 19,
            });
            estudiantes.Add(new Estudiante
            {
                Id = 3,
                Nombre = "Gabriel",
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true,
                Edad = 20,
            });
            return estudiantes;
        }
        
    }
}

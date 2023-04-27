using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    [key]
    public class Movie
    {
        public int Id_pelicula { get; set; }
        public string Nombre {get; set; }
        public string Genero{ get; set; }
      
    }
}

using System.ComponentModel.DataAnnotations;

namespace APIJuego.Models
{
    public class Juego
    {

        [Key]
        public int Id { get; set; }
        public int PlayerNumber { get; set; } 
        public DateTime GameDateTime { get; set; }

    }
}

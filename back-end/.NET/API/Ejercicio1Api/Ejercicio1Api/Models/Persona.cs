namespace Ejercicio1Api.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required int  Edad{ get; set; }
        public required string Email{ get; set; }
        public string? Direccion { get; set; }

    }
}

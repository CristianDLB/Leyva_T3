namespace Leyva_T3.Models
{
    public class Mascota
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo  { get; set; }
        public string Raza  { get; set; }
        public int Tamaño   { get; set; }
        public string Datos { get; set; }
        public int IdCuenta  { get; set; }


    }
}

namespace VentaDeMiel2022.Entidades.Entidades
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }

        public string NombreProvincia { get; set; }

        public int PaisId { get; set; }

        public Pais NombrePais { get; set; }
    }
}

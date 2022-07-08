using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeMiel2022.Entidades.Entidades
{
    public class Localidad
    {
        public int LocalidadId { get; set; }

        public string NombreLocalidad { get; set; }

        public virtual Provincia Provincia { get; set; }
    }
}

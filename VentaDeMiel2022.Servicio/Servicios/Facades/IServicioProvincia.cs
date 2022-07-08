using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Servicio.Servicios.Facades
{
    public interface IServicioProvincia
    {
        void Guardar(Provincia provincia);

        List<Provincia> GetLista();

        void Borrar(int provinciaId);

        Provincia GetProvinciaPorId(int id);
    }
}

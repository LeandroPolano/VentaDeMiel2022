using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioProvincia
    {
        void Guardar( Provincia provincia);

        List<Provincia> GetLista();

        void Borrar(int provinciaId);

        Provincia GetProvinciaPorId(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioProvincia:IServicioProvincia
    {
        private readonly IRepositorioProvincia repositorio;

        public ServicioProvincia()
        {
            repositorio = new RepositorioProvincia();
        }
        public void Guardar(Provincia provincia)
        {
            try
            {
                repositorio.Guardar(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Provincia> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int provinciaId)
        {
            throw new NotImplementedException();
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

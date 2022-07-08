using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioTipoEnvase:IRepositorioTipoEnvase
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioTipoEnvase()
        {
            context = new VentaDeMiel2022DbContext();

        }
        public void Guardar(TipoEnvase tipoEnvase)
        {
            throw new NotImplementedException();
        }

        public List<TipoEnvase> GetLista()
        {
            try
            {
                return context.TipoEnvases.ToList();


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public void Borrar(int tipoEnvaseId)
        {
            throw new NotImplementedException();
        }

        public TipoEnvase GetTipoEnvasePorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

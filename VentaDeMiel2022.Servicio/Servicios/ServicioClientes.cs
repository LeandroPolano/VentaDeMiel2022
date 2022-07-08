using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioClientes : IServicioCliente
    {
        private readonly IRespositorioCliente repositorio;

        public ServicioClientes()
        {
            repositorio = new RepositorioClientes();
        }
        public List<Cliente> Guardar(Cliente cliente)
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

        public List<Cliente> GetLista()
        {
            throw new NotImplementedException();
        }

        public void Borrar(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientePorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

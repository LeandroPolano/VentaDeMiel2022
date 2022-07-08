using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioClientes: IRespositorioCliente
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioClientes()
        {
            context = new VentaDeMiel2022DbContext();

        }
        public List<Cliente> Guardar(Cliente cliente) 
        {
            try
            {
                return context.Clientes.ToList();


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                throw;
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

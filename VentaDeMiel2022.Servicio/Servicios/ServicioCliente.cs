using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioCliente:IServicioClientes
    {
        private readonly IRespositorioCliente repositorio;

        public ServicioCliente()
        {
            repositorio = new RepositorioClientes();
        }
        public void Guardar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public TipoDeDocumento td;
        public Localidad L;
        public Provincia pr;
        public Pais p;
        public Orden orden;
        public List<Cliente> GetLista(TipoDeDocumento td, Localidad L, Provincia pr, Pais p, Orden orden)
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

        public void Borrar(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}

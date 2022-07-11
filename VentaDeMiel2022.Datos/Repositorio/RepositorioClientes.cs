using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioClientes: IRespositorioCliente
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioClientes()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Guardar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente d;
        public List<Cliente> GetLista(TipoDeDocumento td = null, Localidad L = null, Provincia pr = null, Pais p=null, Orden orden=Orden.BD)
        {
            try
            {
                var query = context.Clientes.Include(td.Descripcion);
                var localidadDbQuery = context.Clientes.Include(L.NombreLocalidad);
                var provinciaDbQuery = context.Clientes.Include(pr.NombreProvincia);
                var paisDbQuery = context.Clientes.Include(p.NombrePais);
                if (td != null && L != null && pr != null && p != null)
                {
                    query = (DbQuery<Cliente>)query.Where(d => d.TipoDeDocumentoId == d.TipoDeDocumentoId);
                    localidadDbQuery = (DbQuery<Cliente>)localidadDbQuery.Where(d => d.LocalidadId == d.LocalidadId);
                    provinciaDbQuery = (DbQuery<Cliente>) provinciaDbQuery.Where(d => d.ProvinciaId == d.ProvinciaId);
                    paisDbQuery = (DbQuery<Cliente>) paisDbQuery.Where(d => d.PaisId == d.PaisId);
                }

                switch (orden)
                {
                    case Orden.BD:
                        break;
                    case Orden.AZ:
                        query = (DbQuery<Cliente>) query.OrderBy(p => p.Nombre);
                        break;
                    case Orden.ZA:
                        query = (DbQuery<Cliente>) query.OrderByDescending(p => p.Nombre);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
                }
                return query
                    .AsNoTracking()
                    .ToList();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Servicio.Servicios.Facades
{
    public interface IServicioCliente
    {
        List<Cliente> Guardar(Cliente cliente);

        List<Cliente> GetLista();

        void Borrar(int clienteId);

        Cliente GetClientePorId(int id);
    }
}

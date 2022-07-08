using System.Collections.Generic;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRespositorioCliente
    {
        List<Cliente> Guardar(Cliente cliente);

        List<Cliente> GetLista();

        void Borrar(int clienteId);

        Cliente GetClientePorId(int id);
    }
}

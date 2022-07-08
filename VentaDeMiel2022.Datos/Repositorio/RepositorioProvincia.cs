using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioProvincia:IRepositorioProvincia
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioProvincia()
        {
            context = new VentaDeMiel2022DbContext();
        }

        public void Guardar(Provincia provincia)
        {
            try
            {
                if (provincia.ProvinciaId== 0)
                {
                    context.Provincias.Add(provincia);
                }
                else
                {
                    var provinciaInDb = context.Provincias.SingleOrDefault(p => p.ProvinciaId == provincia.ProvinciaId);
                    if (provinciaInDb == null)
                    {
                        throw new Exception("Código de Provincia inexistente...");
                    }

                    provinciaInDb.NombreProvincia = provincia.NombreProvincia;
                    provinciaInDb.PaisId = provincia.PaisId;

                    context.Entry(provinciaInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
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
                return context.Provincias
                    .Include(p => p.NombrePais)
                    .AsNoTracking()
                    .ToList();
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

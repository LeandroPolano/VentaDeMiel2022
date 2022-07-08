using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioPaises : IRepositorioPais
    {
        private readonly VentaDeMiel2022DbContext context;


        public RepositorioPaises()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Guardar(Pais pais)
        {
            try
            {
                if (pais.PaisId == 0)
                {
                    context.Paises.Add(pais);

                }
                else
                {
                    var PInDb =
                        context.Paises
                            .SingleOrDefault(p => p.PaisId == pais.PaisId);
                    if (PInDb == null)
                    {
                        throw new Exception("Pais no encontrado");
                    }

                    PInDb.NombrePais = pais.NombrePais;
                    context.Entry(PInDb).State = EntityState.Modified;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                if (e.InnerException!=null && e.InnerException.InnerException.Message.Contains("IX"))
                {
                    throw new Exception("Registro Existente");
                }
                throw new Exception(e.Message);
            }
        }

        public List<Pais> GetLista()
        {
            try
            {
                return context.Paises
                    .AsNoTracking()
                    .ToList();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                
            }
        }

        public void Borrar(int paisId)
        {
            try
            {
                var pInDb = context.Paises.SingleOrDefault(p => p.PaisId == paisId);
                if (pInDb == null)
                {
                    throw new Exception("Pais no encontrado");
                }

                context.Entry(pInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                if (e.InnerException!=null && e.InnerException.InnerException.Message.Contains("REFERENCE"))
                {
                    throw new Exception("El registro esta relacionado...");
                }
                throw new Exception(e.Message);
            }
        }
    

        public Pais GetPaisPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

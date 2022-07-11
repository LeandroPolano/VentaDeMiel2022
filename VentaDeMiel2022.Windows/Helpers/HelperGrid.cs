using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGridView)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;

        }
        
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Pais tp:
                    r.Cells[0].Value = ((Pais)obj).NombrePais;
                    break;
                case TipoEnvase te:
                    r.Cells[0].Value = ((TipoEnvase)obj).Descripcion;
                    break;
                case TipoDeDocumento td:
                    r.Cells[0].Value = ((TipoDeDocumento)obj).Descripcion;
                    break;
                case Provincia p:
                    r.Cells[0].Value = ((Provincia)obj).NombreProvincia;
                    r.Cells[1].Value = ((Provincia)obj).NombrePais.NombrePais;
                    break;
                case Localidad L:
                    r.Cells[0].Value = ((Localidad)obj).NombreLocalidad;
                    r.Cells[1].Value = ((Localidad)obj).NombreProvincia.NombreProvincia;
                    break;


            }

            r.Tag = obj;

        }
    }
}

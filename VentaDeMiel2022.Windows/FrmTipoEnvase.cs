using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmTipoEnvase : Form
    {
        public FrmTipoEnvase()
        {
            InitializeComponent();
        }
        private IServicioTipoEnvase servicio;
        private List<TipoEnvase> lista;
        private void TipoEnvase_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoEnvase();
            try
            {
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var tipoEnvase in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, tipoEnvase);
                AgregarFila(r);
            }

        }
        private void SetearFila(DataGridViewRow r, TipoEnvase tipoEnvase)
        {
            r.Cells[colDescripcion.Index].Value = tipoEnvase.Descripcion;

            r.Tag = tipoEnvase;
        }
        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }
    }
}

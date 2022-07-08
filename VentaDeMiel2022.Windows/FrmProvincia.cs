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
    public partial class FrmProvincia : Form
    {
        private IServicioProvincia servicio;
        private List<Provincia> lista;
        public FrmProvincia()
        {
            InitializeComponent();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmProvinciaAE frm = new FrmProvinciaAE() { Text = "Agregar Provincias" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Provincia provincia = frm.GetTipo();
                servicio.Guardar(provincia); 
                 DataGridViewRow r = ConstruirFila();
                SetearFila(r, provincia);
                AgregarFila(r);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            servicio = new ServicioProvincia();
            try
            {
                lista = servicio.GetLista();
               // HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var provincia in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, provincia);
                AgregarFila(r);
            }

        }

        
        private void SetearFila(DataGridViewRow r, Provincia provincia)
        {
            r.Cells[colProvincia.Index].Value = provincia.NombreProvincia;
            r.Cells[colPais.Index].Value =provincia.NombrePais.NombrePais;

            r.Tag = provincia;
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

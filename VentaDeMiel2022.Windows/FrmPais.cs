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
    public partial class FrmPais : Form
    {
        private IServicioPais servicio;
        private List<Pais> lista;
        public FrmPais()
        {
            InitializeComponent();
        }
        private void FrmPais_Load(object sender, EventArgs e)
        {
            servicio = new ServicioPaises();
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
            foreach (var pais in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, pais);
                AgregarFila(r);
            }

        }
        private void SetearFila(DataGridViewRow r, Pais pais)
        {
            r.Cells[colPais.Index].Value = pais.NombrePais;

            r.Tag = pais;
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
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmPaisAE frm = new FrmPaisAE() { Text = "Agregar Paises" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Pais p = frm.GetTipo();
                servicio.Guardar(p);
                var r = ConstruirFila();
                SetearFila(r, p);
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
        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Pais p = (Pais) r.Tag;
            FrmPaisAE frm = new FrmPaisAE() {Text = "Editar Pais"};
            frm.SetTipo(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                p = frm.GetTipo();
                servicio.Guardar(p);
                SetearFila(r, p);
                MessageBox.Show("Registro modificado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Pais p = (Pais)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                servicio.Borrar(p.PaisId);
                DatosDataGridView.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

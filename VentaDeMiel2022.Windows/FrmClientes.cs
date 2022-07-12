using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        private IServicioClientes servicio;
        private List<Cliente> lista;
        private IconButton botonOrdenActual;
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmClienteAE frm = new FrmClienteAE() { Text = "Localidades" };
            DialogResult dr = frm.ShowDialog(this);
        }
        public TipoDeDocumento td;
        public Localidad L;
        public Provincia pr;
        public Pais p;
        public Orden orden;
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            servicio = new ServicioCliente();
            RecargarGrilla(td,L,pr,p,Orden.BD);
        }
        private void RecargarGrilla(TipoDeDocumento td, Localidad L, Provincia pr, Pais p, Orden orden)
        {
            try
            {
                lista = servicio.GetLista( td,  L,  pr,  p,  orden);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }
    }
}

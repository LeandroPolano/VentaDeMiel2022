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
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmClienteAE : Form
    {
        public FrmClienteAE()
        {
            InitializeComponent();
        }

        private IServicioClientes servicio;

        private Cliente cliente;
        public Cliente GetCliente()
        {
            return cliente;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioCliente();
            HelperCombos.CargarDatosComboTipoDocumento(ref TipoDeDocumentoComboBox);
            HelperCombos.CargarDatosComboLocalidad(ref LocalidadComboBox);
            HelperCombos.CargarDatosComboProvincia(ref ProvinciaComboBox);
            HelperCombos.CargarDatosComboPais(ref PaisComboBox);

            if (cliente != null)
            {
                NombreTextBox.Text = cliente.Nombre;
                ApellidoTextBox.Text = cliente.Apellido;
                TipoDeDocumentoComboBox.SelectedValue = cliente.TipoDeDocumentoId;
                NroDocumentoTextBox.Text = cliente.NroDocumento;
                DireccionTextBox.Text = cliente.Direccion;
                LocalidadComboBox.SelectedValue = cliente.LocalidadId;
                ProvinciaComboBox.SelectedValue = cliente.ProvinciaId;
                PaisComboBox.SelectedValue = cliente.PaisId;
                TelefonoFijoTextBox.Text = cliente.TelefonoFijo;
                TelefonoMovilTextBox.Text = cliente.TelefonoMovil;
                CorreoElectronicoTextBox.Text = cliente.CorreoElectronico;


            }

        }
        private void GuardarIconButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {

        }
    }
}
